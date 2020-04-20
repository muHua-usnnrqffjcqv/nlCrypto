using System;
using System.IO;
using System.Security.Cryptography;

namespace nlCrypto
{
    class rsaThings
    {
        public static void KeyGen()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter("PrivateKey.xml"))  //这个文件要保密...
            {
                writer.WriteLine(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter("PublicKey.xml"))
            {
                writer.WriteLine(rsa.ToXmlString(false));
            }
        }
    }
}