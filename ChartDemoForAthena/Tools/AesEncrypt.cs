using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace archive
{
    public class AesEncrypt
    {
        public static void Test()
        {
            string key = "1234567890123456";
            string iv = "1234561234567890";
            string raw = "hello world.";
            string encryptext = Encrypt(raw, key, iv);
            Console.WriteLine(encryptext);

            string plaintext = Decrypt(encryptext, key, iv);
            Console.WriteLine(plaintext);
            Console.Read();
        }

        public static string Encrypt(string toEncrypt, string key, string iv)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return BitConverter.ToString(resultArray).Replace("-", "");
            //return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string toDecrypt, string key, string iv)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            //byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
            byte[] toEncryptArray = Util.StringToByteArray(toDecrypt);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            //return BitConverter.ToString(resultArray).Replace("-", "");
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        
        public static byte[] Decrypt(byte[] toDecryptArray, int suffixLen , string key, string iv)
        //suffixLen  从toEncryptArray去除尾部不需要的字节
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            var arr = new byte[toDecryptArray.Length - suffixLen];
            Array.Copy(toDecryptArray, arr, arr.Length);
            byte[] resultArray = cTransform.TransformFinalBlock(arr, 0, arr.Length);
            //return BitConverter.ToString(resultArray).Replace("-", "");
            return resultArray;
        }

        public static Stream EncryptFile(Stream inputFile, string key, string iv)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            var ret = new MemoryStream();

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;


            CryptoStream cs = new CryptoStream(ret,
                 rDel.CreateEncryptor(),
                CryptoStreamMode.Write);

            inputFile.Position = 0;
            int data;
            while ((data = inputFile.ReadByte()) != -1)
                cs.WriteByte((byte)data);
            ret.Position = 0;
            return ret;
        }

        public static Stream DecryptFile(Stream inputFile, string key, string iv)
        {   
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            var ret = new MemoryStream();

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            CryptoStream cs = new CryptoStream(ret,
                rDel.CreateDecryptor(),
                CryptoStreamMode.Read);
            

            inputFile.Position = 0;
            int data;
            while ((data = cs.ReadByte()) != -1)
                ret.WriteByte((byte)data);

            ret.Position = 0;
            return ret;

        }

        public static void EncryptFile(string inputFile, string outputFile, string key, string iv)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            

            CryptoStream cs = new CryptoStream(fsCrypt,
                 rDel.CreateEncryptor(),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();

        }

        public static void DecryptFile(string inputFile, string outputFile, string key, string iv)
        {

            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(iv);
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            CryptoStream cs = new CryptoStream(fsCrypt,
                rDel.CreateDecryptor(),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

        }
    }
}
