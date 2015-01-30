using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CVVCalc
{

    public class GenerateCVV
    {
        private String PAN;
        private String ExpirationDate;
        private String ServiceCode;
        private String KeyA;
        private String KeyB;
        private String IP;
        private int Port;

        public GenerateCVV(String ip, int port, String pan, String expirationDate, String serviceCode, String keyA, String keyB)
        {
            this.IP = ip;
            this.Port = port;
            this.PAN = pan;
            this.ExpirationDate = expirationDate;
            this.ServiceCode = serviceCode;
            this.KeyA = keyA;
            this.KeyB = keyB;
        }

        public String getCVV()
        {
            return calcCVV(PAN, ExpirationDate, ServiceCode);
        }

        public String getIndentCVV()
        {
            return calcCVV(PAN, ExpirationDate, "000");
        }

        public String getICVV()
        {
            return calcCVV(PAN, ExpirationDate, "999");
        }

        private String calcCVV(String pan, String expirationDate, String serviceCode)
        {
            String CVV=String.Empty;
            //Step-1
            String extractData = String.Empty, block1 = String.Empty, block2 = String.Empty;

            //Step-2
            extractData = (pan + expirationDate + serviceCode).PadRight(32, '0');

            //Step-3
            block1 = extractData.Substring(0, 16);
            block2 = extractData.Substring(16, 16);

            /*
            //Step-4
            String Step4Result = Util.DES(Util.Cryption.Encrypt, block1, KeyA);
            throw new Exception(Step4Result);

            //Step-5
            String XorResult = Util.xorBytes(Step4Result, block2);
            String Step5Result = Util.DES(Util.Cryption.Encrypt, XorResult, KeyA);

            //Step-6
            String Step6Result = Util.DES(Util.Cryption.Decrypt, Step5Result, KeyB);

            //Step-7
            String Step7Result = Util.DES(Util.Cryption.Encrypt, Step6Result, KeyA);
            */

            ///*
            String Step4Result = String.Empty;
            String XorResult = String.Empty;
            String Step7Result = String.Empty;

            try
            {
                HSMClient HSM = new HSMClient(new TcpClient(IP, Port));
                //HSMClient HSM = new HSMClient(new TcpClient("192.168.30.168", 1500));
                HSM.initOps();
                Step4Result = HSM.DES_Encrypt(DesMode.ECB, KeyLength.Single, 1, KeyPair.KP14, KeyA, block1);
                XorResult = Util.xorBytes(Step4Result, block2);
                Step7Result = HSM.DES_Encrypt(DesMode.ECB, KeyLength.Double, 1, KeyPair.KP14, KeyA + KeyB, XorResult);
                HSM.TermClient();
                HSM = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //*/

            //Step-8
            String Step8Result = String.Empty;
            String ExtractHex = String.Empty;
            for (int i = 0; i < Step7Result.Length; i++)
            {
                if (Char.IsDigit(Step7Result, i))
                    Step8Result += Step7Result.Substring(i, 1);
                else
                    ExtractHex += Step7Result.Substring(i, 1);
            }

            //Step-9
            String Step9Result = String.Empty;
            for (int i = 0; i < ExtractHex.Length; i++)
                Step9Result += (Convert.ToChar(ExtractHex.Substring(i, 1)) - 'A').ToString();

            //Step-10
            String Concatenate = Step8Result + Step9Result;

            return Concatenate.Substring(0, 3);
        }




    }
}
