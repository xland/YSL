using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace YSL.Common
{
    public class Encrypt
    {
        public static string getMD5Code(string inStr)
        {
            inStr = string.Format("QinShuBao{0}YuChiGong", inStr);
            var md5 = MD5.Create();
            var result = md5.ComputeHash(Encoding.UTF8.GetBytes(inStr));
            md5.Dispose();
            var strResult = BitConverter.ToString(result);
            return strResult.Replace("-", "");
        }
    }
}
