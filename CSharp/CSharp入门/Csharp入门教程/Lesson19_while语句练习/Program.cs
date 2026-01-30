using System;

namespace Lesson18_while语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while语句练习");
            #region 练习题一
            //int i = 0;
            //while(i<100)
            //{
            //    ++i;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题二
            //int i = 0;
            //int sum = 0;
            //while (i < 100)
            //{
            //    ++i;
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            #endregion

            #region 练习题三
            //int i = 0;
            //int sum = 0;
            //while (i < 100)
            //{
            //    ++i;
            //    if( i % 7 == 0 )
            //    {
            //        continue;
            //    }
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            #endregion

            #region 练习题四
            //try
            //{
            //    Console.WriteLine("请输入一个正整数");
            //    int num = int.Parse(Console.ReadLine());
            //    int index = 2;
            //    while (index < num)
            //    {
            //        if (num % index == 0)
            //        {
            //            break;
            //        }
            //        ++index;
            //    }
            //    if (index == num)
            //    {
            //        Console.WriteLine("{0}是素数", num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}不是素数", num);
            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("请输入正确数字");
            //}

            #endregion

            #region 练习题五

            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //while (userName != "admin" || password != "8888")
            //{
            //    Console.WriteLine("用户名或密码错误，请重新输入");
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("登录成功");

            #endregion

            #region 练习题六

            //Console.WriteLine("请输入班级人数");
            //int classSize = int.Parse(Console.ReadLine());
            //int i = 1;
            //int totalScore = 0;
            //while (i <= classSize)
            //{
            //    Console.WriteLine("请输入{0}位学员成绩",i);
            //    int score = int.Parse(Console.ReadLine());
            //    i++;
            //    totalScore += score;
            //}
            //Console.WriteLine("班级总分是{0},平均分是{1}", totalScore, totalScore / classSize);

            #endregion

            #region 练习题七
            //int i = 0;
            //int sum = 0;
            //while (i < 100)
            //{
            //    ++i;
            //    sum += i;
            //    if (sum >= 500)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("累加到{0}个数字可使sum大于500",i);
            #endregion

            #region 练习题八

            //int num = 100;
            //int month = 0;
            //while (num <= 1000)
            //{
            //    num += (int)(num * 0.2f);
            //    ++month;
            //}
            //Console.WriteLine("需要{0}个月，观众有1000人", month);

            #endregion

            #region 练习题九
            //Console.WriteLine("请输入你要计算的位数");
            //int digit = int.Parse(Console.ReadLine());
            //int index = 0;
            //int n1 = 1;
            //int n2 = 1;
            //int result = 0;
            //while (index < digit)
            //{
            //    ++index;
            //    if (index == 1)
            //    { 
            //        result = 1;
            //    }
            //    else if (index == 2)
            //    {
            //        result = 1;
            //    }
            //    else
            //    {
            //        result = n1 + n2;
            //        n1 = n2;
            //        n2 = result;
            //    }
            //}
            //Console.WriteLine(result);

            #endregion

            #region 练习题十
            int num = 2;
            while (num < 100)
            {
                int index = 2;
                while(index<num)
                {
                    if(num % index == 0)
                    {
                        break;
                    }
                    ++index;
                    if(index == num)
                    {
                        Console.WriteLine("{0}是素数", num);
                    }
                }
                ++num;
            }
            #endregion

        }
    }
}