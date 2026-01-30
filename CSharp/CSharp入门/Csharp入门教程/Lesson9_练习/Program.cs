using System;

namespace Lesson9_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            try
            {
                Console.WriteLine("请输入一个数字：");
                string str = Console.ReadLine();
                long i = long.Parse(str);
                Console.WriteLine("你输入的数字为："+i);
            }
            catch
            {
                Console.WriteLine("输入的内容不符合规范");
            }
            #endregion
            #region 练习题二
            try
            {
                Console.WriteLine("输入姓名：");
                string yourName = Console.ReadLine();
                Console.WriteLine("输入语文成绩：");
                String yuWenStr = Console.ReadLine();
                int yuWen = int.Parse(yuWenStr);
                Console.WriteLine("输入数学成绩：");
                int shuXue = int.Parse(Console.ReadLine());
                Console.WriteLine("输入英语成绩：");
                int yingYu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的内容不符合规范，请重新输入");
            }
            finally
            {
                Console.WriteLine("输入结束");
            }

            #endregion
        }
    }
}
