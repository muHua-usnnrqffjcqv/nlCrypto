using System;
using System.Security.Cryptography;
using System.Text;

namespace nlCrypto
{
    class marsCode
    {
        private byte[] AESE = new byte[16];
        private byte[] AESKEY = new byte[32];
        private string DEFULTKEY = ")(d*4(8)s)g)Z%B$M%B$M#6@D^H&)(";  // 默认密码
        public marsCode(string password)
        {
            init(password);
        }

        public string enc(string inText)
        {
            return ")(" + Encrypt(Encoding.UTF8.GetBytes(inText), AESKEY, AESE) + ")(";
        }
        public string dec(string inText)
        {
            inText = inText.Replace(" ", "");
            inText = inText.Replace("\r", "");
            inText = inText.Replace("\n", "");
            inText = inText.Replace("(", "");
            inText = inText.Replace(")", "");
            return Decrypt(Convert.FromBase64String(inText), AESKEY, AESE);
        }
        private void init(String str)        // 实质：可能事其他密码处理 DEFULTKEY+输入 然后再shabytes
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DEFULTKEY);
            stringBuilder.Append(str);
            shabytes(stringBuilder.ToString());
            // sha-384之后的DEFAULTKEY高16位给AESE，低32位给AESKEY
        }
        private void shabytes(String str)   // 密码处理算法
        {

            byte[] digest = SHA384Encrypt(str);
            int length = digest.Length - AESE.Length; // length=sha-384之后的-原来的(?)
                                                      // length = 80
            for (int i = 0; i < digest.Length; i++)
            { // 循环sha-384长度
              // sha-384长度:96 AESE:16 AESKEY:32
                if (i < AESKEY.Length)
                { // digest的低32位给AESKEY
                    AESKEY[i] = digest[i];
                }
                if (i >= length)
                { // digest的高16位给AESE
                  // 如果 i 大于等于 80
                    int i2 = i - length;
                    // i2 = i-80
                    AESE[i2] = digest[i];
                    // AESE的[i-80]=digest的[i]
                }
            }

        }
        private byte[] SHA384Encrypt(string str)
        {
            System.Security.Cryptography.SHA384 s384 = new System.Security.Cryptography.SHA384Managed();
            byte[] byte1;
            byte1 = s384.ComputeHash(Encoding.Default.GetBytes(str));
            s384.Clear();
            return (byte1);
        }
        private string Encrypt(byte[] toEncrypt, byte[] key, byte[] iv)
        {
            byte[] keyArray = key;
            byte[] ivArray = iv;
            byte[] toEncryptArray = toEncrypt;

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private string Decrypt(byte[] toDecrypt, byte[] key, byte[] iv)
        {
            byte[] keyArray = key;
            byte[] ivArray = iv;
            byte[] toEncryptArray = toDecrypt;

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
