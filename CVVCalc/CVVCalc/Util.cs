using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CVVCalc
{
    public static class Util
    {
        public enum Cryption { Encrypt = 1, Decrypt = 0 };

        public static String DES(Cryption crypt, String hexString, String key, String iv = "0000000000000000")
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            ICryptoTransform desencrypt = null;

            des.Key = hex2Bytes(key);
            des.IV = hex2Bytes(iv);
            des.Padding = PaddingMode.Zeros;
            byte[] cryptData = hex2Bytes(hexString);

            if (crypt == Cryption.Encrypt)
                desencrypt = des.CreateEncryptor();
            else
                desencrypt = des.CreateDecryptor();
            return BitConverter.ToString(
                desencrypt.TransformFinalBlock(cryptData, 0, cryptData.Length)).Replace("-", string.Empty);
        }

        public static Byte[] hex2Bytes(String hexString)
        {
            Byte[] bytes = new Byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length / 2; i++)
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return bytes;
        }

        public static String xorBytes(String hexString1, String hexString2)
        {
            Byte[] b1 = hex2Bytes(hexString1);
            Byte[] b2 = hex2Bytes(hexString2);
            Byte[] bytes = new Byte[hexString1.Length / 2];

            for (int i = 0; i < b1.Length; i++)
                bytes[i] = (Byte)(b1[i] ^ b2[i]);

            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}
