using System;

namespace Lesson8_练习
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("练习题");

            #region 练习题一
            //显示类型转换有几种方法
            //1.括号强转 数值之间的转换 低精度装高精度
            int i = 1;
            long l = 1;
            i = (int)l;

            float f = 1.1f;
            double d = 1.1234567890123456789;
            f = (float)d;
            //parse法 把字符串转成对应类型
            i = int.Parse("123");
            //3.convert法
            i = Convert.ToInt32(123.2212);
            i = Convert.ToInt32("123132");

            string str = Convert.ToString(123123);
            //4.使用toString方法
            str = 1.ToString();
            str = 1.123f.ToString();
            #endregion

            #region 练习题二
            //请将24069转成字符并打印

            char c = (char)24069;
            Console.WriteLine(c);

            c = Convert.ToChar(24069);
            Console.WriteLine(c);
            #endregion

            #region 练习题三
            //提示用户输入姓名、语文、数学、英语成绩，并将输入的3门成绩用整形变量存储
            Console.WriteLine("请输入姓名：");
            string str2 = Console.ReadLine();

            Console.WriteLine("请输入语文：");
            str2 = Console.ReadLine();
            int yuWen = int.Parse(str2);
            Console.WriteLine("你的语文成绩"+yuWen);

            Console.WriteLine("请输入数学：");
            str2 = Console.ReadLine();
            int shuXue  = int.Parse(str2);
            Console.WriteLine("你的数学成绩" + shuXue);

            Console.WriteLine("请输入英语：");
            str2 = Console.ReadLine();
            int yingYU = int.Parse(str2);
            Console.WriteLine("你的英语成绩" + yingYU);

            #endregion
        }
    }
}


