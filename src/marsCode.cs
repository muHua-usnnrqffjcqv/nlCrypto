using System;
using System.Security.Cryptography;
using System.Text;

namespace nlCrypto
{
    class marsCode
    {
        private byte[] AESE = new byte[16];
        private byte[] AESKEY = new byte[32];
        private string DEFULTKEY = ")(d*4(8)s)g)Z%B$M%B$M#6@D^H&)(";  // Ĭ������
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
        private void init(String str)        // ʵ�ʣ��������������봦�� DEFULTKEY+���� Ȼ����shabytes
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DEFULTKEY);
            stringBuilder.Append(str);
            shabytes(stringBuilder.ToString());
            // sha-384֮���DEFAULTKEY��16λ��AESE����32λ��AESKEY
        }
        private void shabytes(String str)   // ���봦���㷨
        {

            byte[] digest = SHA384Encrypt(str);
            int length = digest.Length - AESE.Length; // length=sha-384֮���-ԭ����(?)
                                                      // length = 80
            for (int i = 0; i < digest.Length; i++)
            { // ѭ��sha-384����
              // sha-384����:96 AESE:16 AESKEY:32
                if (i < AESKEY.Length)
                { // digest�ĵ�32λ��AESKEY
                    AESKEY[i] = digest[i];
                }
                if (i >= length)
                { // digest�ĸ�16λ��AESE
                  // ��� i ���ڵ��� 80
                    int i2 = i - length;
                    // i2 = i-80
                    AESE[i2] = digest[i];
                    // AESE��[i-80]=digest��[i]
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
