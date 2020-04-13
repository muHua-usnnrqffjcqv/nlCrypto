using System;
using System.Security.Cryptography;
using System.Text;

namespace nlCrypto
{
public class AesClass
{
    /// <summary>
    ///  AES 加密
    /// </summary>
    /// <param name="str">明文（待加密）</param>
    /// <param name="key">密文</param>
    /// <returns></returns>
    public static string AesEncrypt(string str, string key)
    {
        if (string.IsNullOrEmpty(str)) {
            return null;
        }

        byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);

        RijndaelManaged rm = new RijndaelManaged {
            Key = Encoding.UTF8.GetBytes(key),
            Mode = CipherMode.ECB,
            Padding = PaddingMode.PKCS7
        };
        ICryptoTransform cTransform = rm.CreateEncryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }
    /// <summary>
    ///  AES 解密
    /// </summary>
    /// <param name="str">明文（待解密）</param>
    /// <param name="key">密文</param>
    /// <returns></returns>
    public static string AesDecrypt(string str, string key)
    {
        if (string.IsNullOrEmpty(str)) {
            return null;
        }

        byte[] toEncryptArray = Convert.FromBase64String(str);

        RijndaelManaged rm = new RijndaelManaged {
            Key = Encoding.UTF8.GetBytes(key),
            Mode = CipherMode.ECB,
            Padding = PaddingMode.PKCS7
        };

        ICryptoTransform cTransform = rm.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        return Encoding.UTF8.GetString(resultArray);
    }
}

}