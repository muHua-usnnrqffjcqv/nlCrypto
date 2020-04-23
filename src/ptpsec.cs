using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace nlCrypto
{
    class ptpsec
    {
        public struct TempKey
        {
            public string output;
            public int encPwd;
        }

        public static TempKey TempKeyGen(string publicKey)
        {
            TempKey v;
            if (publicKey == null)
            {
                v.output = "";
                v.encPwd = 0;
                return v;
            }
            Random ran = new Random();
            int encPwd = ran.Next();
            v.output = rsa.encrypt(publicKey, encPwd.ToString());
            v.encPwd = encPwd;
            return v;
        }

        public static int TempKeyDecode(string privateKey, TempKey tempKey)
        {
            if (privateKey == null)
            {
                return 0;
            }
            string all = rsa.decrypt(privateKey, tempKey.output);
            return tempKey.encPwd + Convert.ToInt32(all);
            // 使用完请将tempKey.encPwd置0
        }
    }
    class nlPtpsec
    {
        public struct nlTempKey
        {
            public string output;
            public int encPwd;
        }
        public static nlTempKey TempKeyGen(string publicKeyWhere, bool usingLongword)
        {
            StreamReader publicSr = new StreamReader(publicKeyWhere);
            ptpsec.TempKey tempKey = ptpsec.TempKeyGen(publicSr.ReadLine());
            nlTempKey nlTempKey;
            nlTempKey.output = nlb.encode(tempKey.output, usingLongword);
            nlTempKey.encPwd = tempKey.encPwd;
            return nlTempKey;
        }
        public static int nlTempKeyDecode(string privateKeyWhere, nlTempKey nlTempKey)
        {
            StreamReader privateSr = new StreamReader(privateKeyWhere);
            ptpsec.TempKey tempKey;
            tempKey.output = nlb.decode(nlTempKey.output);
            tempKey.encPwd = nlTempKey.encPwd;
            return ptpsec.TempKeyDecode(privateSr.ReadLine(), tempKey);
            // 使用完请讲tempkey.encpwd置0
        }
    }
    class rsa
    {
        public static void KeyGen()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            Directory.CreateDirectory(System.Environment.GetEnvironmentVariable("UserProfile") + "\\Keys");
            using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("UserProfile") + "\\Keys\\PrivateKey.xml"))  //这个文件要保密...
            {
                writer.WriteLine(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("UserProfile") + "\\Keys\\PublicKey.xml"))
            {
                writer.WriteLine(rsa.ToXmlString(false));
            }
        }
        public static string encrypt(string publickey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(publickey);
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
            return Convert.ToBase64String(cipherbytes);
        }
        public static string decrypt(string privatekey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(privatekey);
            cipherbytes = rsa.Decrypt(Convert.FromBase64String(content), false);
            return Encoding.UTF8.GetString(cipherbytes);
        }
    }
}
