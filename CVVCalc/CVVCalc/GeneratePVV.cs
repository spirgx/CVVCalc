using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CVVCalc
{
    public class GeneratePVV
    {
        private String PAN;
        private String PVKI;
        private String PIN;
        private String KeyA;
        private String KeyB;
        private String IP;
        private int Port;
 
        public GeneratePVV(String ip, int port ,String pan, String pvki, String pin, String keyA, String keyB)
        {
            this.IP = ip;
            this.Port = port;
            this.PAN = pan;
            this.PVKI = pvki;
            this.PIN = pin;
            this.KeyA = keyA;
            this.KeyB = keyB;
        }



        public String getTSP()
        {
            return PAN.Substring(4, 11) + PVKI + PIN.Substring(0, 4);
        }

        public String getPVV()
        {
            return calcPVV();
        }

        private string calcPVV()
        {
            String PVV = String.Empty;
            //Step-1
            String TSP = getTSP();

            /*
            //Step-2
            String Step2Result = Util.DES(Util.Cryption.Encrypt, TSP, KeyA);

            //Step-3
            String Step3Result = Util.DES(Util.Cryption.Decrypt, Step2Result, KeyB);

            //Step-4
            String Step4Result = Util.DES(Util.Cryption.Encrypt, Step3Result, KeyA);
            */
            
            String Step4Result = String.Empty;
            try
            {
                HSMClient HSM = new HSMClient(new TcpClient(IP, Port));
                //HSMClient HSM = new HSMClient(new TcpClient("192.168.30.168", 1500));
                HSM.initOps();
                Step4Result = HSM.DES_Encrypt(DesMode.ECB, KeyLength.Double, 1, KeyPair.KP14, KeyA + KeyB, TSP);
                HSM.TermClient();
                HSM = null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            

            //Step-5
            String Step5Result = String.Empty;
            String ExtractHex = String.Empty;
            for (int i = 0; i < Step4Result.Length; i++)
            {
                if (Char.IsDigit(Step4Result, i))
                    Step5Result += Step4Result.Substring(i, 1);
                else
                    ExtractHex += Step4Result.Substring(i, 1);
            }

            //Step-6
            String Step6Result = String.Empty;
            for (int i = 0; i < ExtractHex.Length; i++)
                Step6Result += (Convert.ToChar(ExtractHex.Substring(i, 1)) - 'A').ToString();

            //Step-7
            String Concatenate = Step5Result + Step6Result;

            return Concatenate.Substring(0, 4);
        }
    }
}
