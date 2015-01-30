using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CVVCalc
{
    public enum DesMode { ECB = 0, CBC = 1 };
    public enum KeyPair { KP30 = 0, KP14 = 1, KP16 = 2, KP18 = 3, KP20 = 4, KP22 = 5, KP28 = 6, KP38 = 7 };
    public enum KeyLength { Single = 0, Double = 1 };

    
    
    class HSMClient
    {
        private TcpClient Client;
        private const int reciveLens = 1024;
        private Byte[] reciveData = new Byte[reciveLens];
        private Boolean connect = false;
        private static string response = "";
        private const String header = "1234";
        
        public HSMClient(TcpClient client)
        {
            this.Client = client;
        }

        public void initOps()
        {
            connect = true;
            Client.GetStream().BeginRead(reciveData, 0, reciveLens, new AsyncCallback(StreamReceive), null);
        }

        public void TermClient()
        {
            try
            {
                connect = false;
                Client.GetStream().Close();
                Client.Close();
            }
            catch(Exception ex) {}           

        }

        private void StreamReceive(IAsyncResult ar)
        {
            int ByteCount = 0;

            try
            {
                lock (Client.GetStream())
                {
                    ByteCount = Client.GetStream().EndRead(ar);
                }

                if (ByteCount < 1)
                {
                    connect = false;
                    Client.Close();
                    return;
                }

                //response += System.Text.ASCIIEncoding.GetEncoding(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ANSICodePage).GetString(reciveData,2,ByteCount);
                if(ByteCount > 0)
                    response += BitConverter.ToString(reciveData, 0, ByteCount).Replace("-", "");
                //response += Encoding.Default.GetString(reciveData, 2, ByteCount);

                lock (Client.GetStream())
                {
                    Client.GetStream().BeginRead(reciveData, 0, reciveLens, new AsyncCallback(StreamReceive), null);
                }

            }
            catch (Exception ex)
            {
                connect = false;
                Client.Close();
                Console.Write("Exception: " + ex.ToString());
            }
        }

        public String send(String command)
        {
            Byte[] buffer = Encoding.ASCII.GetBytes("  " + command);
            //Console.Write("Send: [" + command + "]\n");
            buffer[0] = Convert.ToByte((int)command.Length / 256);
            buffer[1] = Convert.ToByte(command.Length % 256);
            lock (Client.GetStream())
            {
                Client.GetStream().BeginWrite(buffer, 0, buffer.Length, null, null);
            }
            return getResponse();
        }

        public void send(Byte[] command)
        {
            lock (Client.GetStream())
            {
                Client.GetStream().BeginWrite(command, 0, command.Length, null, null);
            }
        }

        public String getResponse()
        {
            response = "";
            while ((response == "") && (connect))
            {
                System.Threading.Thread.Sleep(5);
            }
            return response;
        }

        public String DES_Encrypt(DesMode mode, KeyLength length, int keyVariant, KeyPair pair, String key, String data, String IV = "")
        {
            String command = String.Empty;
            String commandCode = "YY";
            String msg = String.Empty;
            int commandLength = 0;

            if(mode == DesMode.CBC && IV == "")
                throw new Exception("CBC mode need IV value.");

            if((length == KeyLength.Single && key.Length != 16) || 
               (length == KeyLength.Double && key.Length != 32))
                throw new Exception("Key length error.");

            if ((data.Length / 2) % 8 != 0)
                throw new Exception("Data length must in multiples of 8 bytes.");

            commandLength = 10 + key.Length + IV.Length / 2 + 3 + data.Length / 2;

            command = header + commandCode + ((int)mode).ToString() + ((int)length).ToString() 
                                        + keyVariant.ToString() + ((int)pair).ToString() + key;

            command = Convert.ToString(commandLength, 16).PadLeft(4, '0')
                                        + BitConverter.ToString(Encoding.ASCII.GetBytes(command)).Replace("-", "");
            command += IV;
            command += BitConverter.ToString(Encoding.ASCII.GetBytes((data.Length / 2).ToString("000"))).Replace("-", "");
            command += data;

            send(SoapHexBinary.Parse(command).Value);
            msg = getResponse();

            if (msg.Substring(16, 4) != "3030")
                ReturnErrorMsg(msg.Substring(16, 4));

            return msg.Substring(20);
        }

        public String DES_Decrypt(DesMode mode, KeyLength length, int keyVariant, KeyPair pair, String key, String data, String IV = "")
        {
            String command = String.Empty;
            String commandCode = "ZC";
            String msg = String.Empty;
            int commandLength = 0;

            if (mode == DesMode.CBC && IV == "")
                throw new Exception("CBC mode need IV value.");

            if ((length == KeyLength.Single && key.Length != 16) ||
               (length == KeyLength.Double && key.Length != 32))
                throw new Exception("Key length error.");

            if ((data.Length / 2) % 8 != 0)
                throw new Exception("Data length must in multiples of 8 bytes.");

            commandLength = 10 + key.Length + IV.Length / 2 + 3 + data.Length / 2;

            command = header + commandCode + ((int)mode).ToString() + ((int)length).ToString()
                                        + keyVariant.ToString() + ((int)pair).ToString() + key;

            command = Convert.ToString(commandLength, 16).PadLeft(4, '0')
                                        + BitConverter.ToString(Encoding.ASCII.GetBytes(command)).Replace("-", "");
            command += IV;
            command += BitConverter.ToString(Encoding.ASCII.GetBytes((data.Length / 2).ToString("000"))).Replace("-", "");
            command += data;

            send(SoapHexBinary.Parse(command).Value);
            msg = getResponse();

            if (msg.Substring(16, 4) != "3030")
                ReturnErrorMsg(msg.Substring(16, 4));

            return msg.Substring(20);

        }

        private void ReturnErrorMsg(String errorCode)
        {
            switch (errorCode)
            {
                case "3032":
                    throw new Exception("Error02:Invalid Encryption mode");
                case "3033":
                    throw new Exception("Error03:Invalid Encryption Key Length");
                case "3034":
                    throw new Exception("Error04:Invalid Encryption pair");
                case "3036":
                    throw new Exception("Error06:Invalid Key Variant");
                case "3130":
                    throw new Exception("Error10:Encryption Key parity error");
                case "3132":
                    throw new Exception("Error12:No keys loaded in user storage");
                case "3133":
                    throw new Exception("Error13:LMK error, report to supervisor");
                case "3135":
                    throw new Exception("Error15:Invalid input data");
                case "3231":
                    throw new Exception("Error21:Invalid user storage index");
                case "3830":
                    throw new Exception("Error80:Length of Clear Text Data not equal to Data Length or length is not divisible by 8");
            }

        }

    }
}
