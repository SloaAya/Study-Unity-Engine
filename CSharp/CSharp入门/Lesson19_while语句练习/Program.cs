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
            try
            {
                Console.WriteLine("请输入一个正整数");
                int i = int.Parse(Console.ReadLine());
                while (i > 0)
                {
                    
                }
            }
            catch 
            {

                Console.WriteLine("请输入正确数字");
            }

            #endregion
        }
    }
}