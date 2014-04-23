using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace MX_Encrypt.web
{
    /// <summary>
    /// Encrypt 的摘要说明
    /// </summary>
    public class Encrypt
    {
        public Encrypt()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        ///   <summary>   
        ///   采用标准   64位   DES   算法加密   
        ///   </summary>   
        ///   <param   name="strText">要加密的字符串</param>   
        ///   <returns>返回加密后的字符串</returns>   
        public string DESEncrypt(string strText)
        {
            string text = "19841020";
            byte[] rgbKey = new byte[0];
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            try
            {
                rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] bytes = Encoding.UTF8.GetBytes(strText);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                return Convert.ToBase64String(stream.ToArray());
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        ///   <summary>   
        ///   标准64位DES解密   
        ///   </summary>   
        ///   <param   name="strText">要解密的字符串</param>   
        ///   <returns>返回解密后的字符串</returns>   
        public string DESDecrypt(string strText)
        {
            string text = "19841020";
            byte[] rgbKey = new byte[0];
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            byte[] buffer3 = new byte[strText.Length];
            try
            {
                rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                buffer3 = Convert.FromBase64String(strText);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                stream2.Write(buffer3, 0, buffer3.Length);
                stream2.FlushFinalBlock();
                return Encoding.UTF8.GetString(stream.ToArray());
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// 方法一:通过使用 new 运算符创建对象
        /// </summary>
        /// <param name="strSource">需要加密的明文</param>
        /// <returns>返回16位加密结果，该结果取32位加密结果的第9位到25位</returns>
        public string Get_MD5_Method16(string strSource)
        {
            //new
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //获取密文字节数组
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(strSource));

            //转换成字符串，并取9到25位
            string strResult = BitConverter.ToString(bytResult, 4, 8);
            //转换成字符串，32位
            //string strResult = BitConverter.ToString(bytResult);

            //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉
            strResult = strResult.Replace("-", "");
            return strResult;
        }

        /// <summary>
        /// 方法二:通过调用特定加密算法的抽象类上的 Create 方法，创建实现特定加密算法的对象。
        /// </summary>
        /// <param name="strSource">需要加密的明文</param>
        /// <returns>返回32位加密结果</returns>
        public string Get_MD5_Method32(string strSource)
        {
            string strResult = "";

            //Create
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            //注意编码UTF8、UTF7、Unicode等的选择　
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strSource));

            //字节类型的数组转换为字符串
            for (int i = 0; i < bytResult.Length; i++)
            {
                //16进制转换 
                strResult = strResult + bytResult[i].ToString("X");
            }
            return strResult;
        }
    }
}
