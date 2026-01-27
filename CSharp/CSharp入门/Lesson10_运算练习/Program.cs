using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Lesson10_算数运算符练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算练习");

            Console.WriteLine("你的年龄：");
            string myAge = Console.ReadLine();
            int TenYearmyAge = int.Parse(myAge) + 10;
            Console.WriteLine("十年后的年龄是：" + TenYearmyAge);

            int r = 5;
            float π = 3.14f;
            Console.WriteLine("圆的面积是：" + π * r * r);
            Console.WriteLine("圆的周长是：" + 2 * π * r);

            Console.WriteLine("请输入语文成绩：");
            string yuWen = Console.ReadLine();
            Console.WriteLine("请输入数学成绩：");
            string shuXue = Console.ReadLine();
            Console.WriteLine("请输入英语成绩：");
            string yingYU = Console.ReadLine();
            int totalScore = int.Parse(yuWen) + int.Parse(shuXue) + int.Parse(yingYU);
            Console.WriteLine("你的总成绩为：" + totalScore);
            int averageScore = totalScore / 3;
            Console.WriteLine("你的平均成绩为：" + averageScore);

            int TshirtPrice = 285;
            int trousers = 720;
            int totalCost = TshirtPrice * 2 + trousers * 3;
            float discount = (TshirtPrice * 2 + trousers * 3) * 0.38f;
            Console.WriteLine("总花费：" + totalCost);
            Console.WriteLine("打折后：" + discount);

            int a = 99;
            int b = 87;

            int temp = a;
            a = b;
            b = temp;

            a = 99;
            b = 87;
            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine(a);
            Console.WriteLine(b);

            int time = 987652;
            int day = time / 86400;
            int hour = (time % 86400) / 3600;
            int minute = (time % 86400) % 3600 / 60;
            int second = (time % 86400) % 3600 % 60;
            Console.WriteLine("天：" + day + " 时：" + hour + " 分：" + minute + " 秒：" + second);


        }
    }
}