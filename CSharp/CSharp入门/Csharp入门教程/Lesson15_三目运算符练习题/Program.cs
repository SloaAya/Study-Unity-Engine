using System;

namespace Lesson15_三目运算符练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符练习题");
            #region 练习题一
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //int c = int.Parse(a);
            //int d = int.Parse(b);
            //int max = c > d ? c : d;
            //Console.WriteLine(max);
            #endregion

            #region 练习题二
            //Console.WriteLine("请输入一个姓名");
            //string name = Console.ReadLine();
            //name = name == "帅哥" ? "帅哥" : "美女";
            //Console.WriteLine(name);
            #endregion

            #region 练习题三
            //Console.WriteLine("姓名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入C#成绩");
            //string csharpScoreStr = Console.ReadLine();
            //Console.WriteLine("Unity成绩：");
            //string unityScoreStr = Console.ReadLine();

            //int csharpScore = int.Parse(csharpScoreStr);
            //int unityScore = int.Parse(unityScoreStr);

            //string biye = csharpScore >= 90 && unityScore >= 90 ? "毕业" : "无法毕业";
            //Console.WriteLine(biye);
            #endregion

            #region 练习题四
            Console.WriteLine("请如数一个年份");
            string yearStr = Console.ReadLine();
            int year = int.Parse(yearStr);

            string runNian = (year % 400 == 0) || (year % 4 ==0 && year % 100!=0) ? "是闰年" : "不是闰年";
            Console.WriteLine(runNian);

            #endregion  
        }
    }
}