using System;

namespace Lesson16_if语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句练习");

            #region 练习题一
            //Console.WriteLine("请用户输入今日看唐老师视频花了多少分钟");
            //string timeStr = Console.ReadLine();
            //int time = int.Parse(timeStr);
            //if(time > 60)
            //{
            //    Console.WriteLine("今天看视频花了" + time + "分钟，看来你离成功又进了一步");
            //}

            #endregion

            #region  练习题二
            //Console.WriteLine("请输入你的语文成绩");
            //string yuWenstr = Console.ReadLine();
            //Console.WriteLine("请输入你的数学成绩");
            //string shuXuestr = Console.ReadLine();
            //Console.WriteLine("请输入你的英语成绩");
            //string yingYustr = Console.ReadLine();
            //int yuWen = int.Parse(yuWenstr);
            //int shuXue = int.Parse(shuXuestr);
            //int yingYu = int.Parse(yingYustr);

            //if (yuWen>70 && shuXue>80 && yingYu>90)
            //{
            //    Console.WriteLine("非常棒，继续加油");
            //}
            //else if (yuWen == 100 || shuXue == 100 || yingYu == 100)
            //{
            //    Console.WriteLine("非常棒，继续加油");
            //}
            //else if (yuWen >90 && (shuXue>70 || yingYu>70))
            //{
            //    Console.WriteLine("非常棒，继续加油");
            //}


            #endregion

            #region 练习题三
            //Console.WriteLine("小明的成绩");
            //string scoreStr = Console.ReadLine();
            //int score = int.Parse(scoreStr);

            //if (score >= 90)
            //{
            //    Console.WriteLine("奖励一百元");
            //}
            //else
            //{
            //    Console.WriteLine("一个月不能玩游戏");
            //}

            #endregion

            #region 练习题四
            //Console.WriteLine("请输入a值");
            //string aStr = Console.ReadLine();
            //Console.WriteLine("请输入b值");
            //string bStr = Console.ReadLine();
            //int a = int.Parse(aStr);
            //int b = int.Parse(bStr);

            //if (a % b == 0 || b % a == 0 || a + b > 100)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //    Console.WriteLine(b);
            #endregion

            #region 练习题五
            //Console.WriteLine("请输入一个整数");
            //string numStr = Console.ReadLine();
            //int num = int.Parse(numStr);
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Your input is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is odd");
            //} 

            #endregion

            #region 练习题六
            //Console.WriteLine("请输入a值");
            //string aStr = Console.ReadLine();
            //Console.WriteLine("请输入b值");
            //string bStr = Console.ReadLine();
            //Console.WriteLine("请输入c值");
            //string cStr = Console.ReadLine();
            //int a = int.Parse(aStr);
            //int b = int.Parse(bStr);
            //int c = int.Parse(cStr);
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b > c )
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c); 
            //}
            #endregion

            #region 练习题七
            
            //try
            //{
            //    Console.WriteLine("请输入一个数字");
            //    char c = Console.ReadKey().KeyChar;
            //    int num = int.Parse(c.ToString());
            //    if (num >= 0 && num <= 9)
            //    { 
            //        Console.WriteLine("你输入了一个数字");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("你输入的不是一个数字");
            //}
            #endregion

            #region 练习题八
            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();

            //if (userName == "admin" && password == "8888")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else
            //{
            //    if (userName != "admin")
            //    {
            //        Console.WriteLine("用户名错误");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}           

            #endregion

            #region 练习题九
            //Console.WriteLine("请用户输入年龄：");
            //string ageStr = Console.ReadLine();
            //int age = int.Parse(ageStr);
            //if (age >= 18)
            //{
            //    Console.WriteLine("可以查看");
            //}
            //else if (age > 13 && age < 18)
            //{
            //    Console.WriteLine("是否继续查看（YES or NO）");
            //    if (Console.ReadLine() == "YES")
            //    {
            //        Console.WriteLine("请用户查看");
            //    }
            //    else
            //    {
            //        Console.WriteLine("退出");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不可以查看");
            //}
            #endregion

            #region 练习题十
            //int a = 5;
            //if (a > 3)
            //{
            //    int b =0;
            //    ++b;
            //    b += a;
            //    Console.WriteLine(b);
            //}
            #endregion

        }
    }
}