using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lesson11_字符串拼接
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接练习题");

            #region 练习题一
            //string Name = "唐老师";
            //Console.WriteLine("你好，" + Name);
            //Console.WriteLine("你好，{0}" , Name);
            //string str =string.Format("你好，{0}", Name);
            //Console.WriteLine(str);
            #endregion

            #region 练习题二
            //string Name = "唐老师";
            //int Age = 99;
            //Console.WriteLine("{0}{1}岁了", Name, Age);
            //Console.WriteLine(Name + Age + "岁了");
            //string str = string.Format("{0}{1}岁了", Name, Age);
            //Console.WriteLine(str);
            #endregion

            #region 练习题三
            //string Name = "唐老师";
            //int Age = 18;
            //string address = "CN";
            //int Salary = 8000;
            //Console.WriteLine("大家好，我是{0}\n我今年{1}岁了\n我来自{2}\n我的月薪是{3}元。", Name, Age, address, Salary);
            //Console.WriteLine("大家好，我是" + Name + "\n我今年" + Age + "岁了\n我来自" + address + "\n我的月薪是" + Salary + "元。");
            //string str = string.Format("大家好，我是{0}\n我今年{1}岁了\n我来自{2}\n我的月薪是{3}元。", Name, Age, address, Salary);
            //Console.WriteLine(str);
            #endregion

            #region 练习题四
            Console.WriteLine("请输入你的用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的班级");
            string className = Console.ReadLine();
            Console.WriteLine("我叫{0}，年龄{1}，班级是{2}",userName,age,className);
            #endregion

        }
    }
}