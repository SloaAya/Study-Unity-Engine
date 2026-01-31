using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

namespace Lesson21_dowhile语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //string userName = "";
            //string passWord = "";
            //bool isShow = false;
            //do 
            //{ 
            //    Console.WriteLine("请输入用户名：");
            //    if(isShow)
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入！");
            //    }
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    passWord = Console.ReadLine();
            //    isShow = true;
            //} while (userName != "admin" || passWord != "8888");
            #endregion

            #region 练习题二
            string input = "";
            do 
            {
                Console.WriteLine("请输入你的姓名：");
                input = Console.ReadLine();
            } while(input != "q");
            #endregion
        }
    }
}