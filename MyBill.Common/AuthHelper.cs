/*
*┌────────────────────────────────────────────────┐
*│　描   述：AuthHelper                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2020-01-06 15:57:08                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MyBill.Common
{
    public class AuthHelper
    {
        public static string GetToken()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string GetPassword()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string password = random.Next(10000000, 99999999).ToString();
            password = MD5(password);
            return password;
        }

        /// <summary>
        /// 位数太长要切手
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int GetRandom(int length = 4)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int number = random.Next((int)(length * Math.Pow((double)10, (double)(length - 1))), (int)Math.Pow(10.0, (double)length) - 1);
            return number;
        }

        public static bool IsMobile(string mobile)
        {
            Regex regex = new Regex(@"^(13|14|15|16|17|18|19)\d{9}$");
            if (regex.IsMatch(mobile))
                return true;
            else
                return false;
        }
        public static bool IsEmail(string email)
        {
            Regex regex = new Regex(@"^[a-z0-9]+([._\\-]*[a-z0-9])*@([a-z0-9]+[-a-z0-9]*[a-z0-9]+.){1,63}[a-z0-9]+$");
            if (regex.IsMatch(email))
                return true;
            else
                return false;
        }


        public static string MD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Default.GetBytes(str));
            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}
