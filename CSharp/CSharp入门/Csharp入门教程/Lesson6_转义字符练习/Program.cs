using System;

namespace Lesson6_转义字符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "我是小明";
            Console.WriteLine(str1);
            string str2 = "我今年18";
            Console.WriteLine(str2);
            string str3 = "我的爱好是制作游戏";
            Console.WriteLine(str3);
            string str4 = "我要好好学习，天天向上";
            Console.WriteLine(str4);
            string str5 = "我是小明\n我今年十八\n我的爱好是制作游戏\n我要好好学习，天天向上";
            Console.WriteLine(str5);
        }
    }
}
