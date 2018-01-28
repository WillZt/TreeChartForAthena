using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web.Mvc;

namespace archive
{
    public static class Chain
    {

        public static string chain_service = ConfigurationManager.AppSettings["chain_service"];
        public static string chain_username = ConfigurationManager.AppSettings["chain_username"];
        public static string chain_uuid = ConfigurationManager.AppSettings["chain_uuid"];
        public static string chain_aeskey = ConfigurationManager.AppSettings["chain_aeskey"];
        public static string chain_aesiv = ConfigurationManager.AppSettings["chain_aesiv"];
        public static string chain_hashkey = ConfigurationManager.AppSettings["chain_hashkey"];


        //public static dynamic sendToChain(string method, object data, List<Stream> files = null, Controller controller=null)
        //{
        //    var timestamp = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        //    var chainData = new Dictionary<string, string>();
        //    chainData["data"] = AesEncrypt.Encrypt(JsonConvert.SerializeObject(data), chain_aeskey, chain_aesiv);
        //    chainData["uuid"] = chain_uuid;
        //    chainData["time"] = timestamp.ToString("F0");
        //    chainData["nonce"] = timestamp.ToString();
        //    var payload = chainData.OrderBy(x => x.Key).Select(x => x.Value).Aggregate((cur, next) => cur + next);
        //    chainData["sign"] = BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(System.Text.Encoding.UTF8.GetBytes(payload + chain_hashkey))).Replace("-", "").ToLower();
            
        //    var content = new CapturedMultipartContent();
        //    chainData.ToList().ForEach(x => content.AddString(x.Key, x.Value));
        //    files?.ForEach(x => content.AddFile("files", AesEncrypt.EncryptFile(x, chain_aeskey, chain_aesiv), "files"));

        //    if (method == "getFile")
        //    {                
        //        //var chainFile = (chain_service + method).PostAsync(content).Result.Content.ReadAsStreamAsync().Result;
        //        //var tmpFile = Path.Combine(controller.Server.MapPath("~/uploads/axivFiles"), "chainFile.tmp");
        //        //var tmpDecryptFile = Path.Combine(controller.Server.MapPath("~/uploads/axivFiles"), "chainFile.tmp.decrypt");
        //        //using (var fileStream = File.Create(tmpFile))
        //        //{
        //        //    chainFile.Seek(0, SeekOrigin.Begin);
        //        //    chainFile.CopyTo(fileStream);
        //        //}
        //        //AesEncrypt.DecryptFile(tmpFile, tmpDecryptFile, chain_aeskey, chain_aesiv);
        //        //return File.OpenRead(tmpDecryptFile);

        //        return AesEncrypt.Decrypt((chain_service + method).PostAsync(content).Result.Content.ReadAsByteArrayAsync().Result,8, chain_aeskey, chain_aesiv);
        //        //return AesEncrypt.DecryptFile((chain_service + method).PostAsync(content).Result.Content.ReadAsStreamAsync().Result, chain_aeskey, chain_aesiv);
        //    }

        //    var res = (chain_service + method).PostAsync(content).ReceiveJson().Result;
        //    if (res.code == 1)
        //        res.data = AesEncrypt.Decrypt(res.data, chain_aeskey, chain_aesiv);            
        //    return res;
        //}

    }
}