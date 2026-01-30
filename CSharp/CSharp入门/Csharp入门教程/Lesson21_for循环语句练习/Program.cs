using System;

namespace Lesson21_for语句练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //for (int i = 0; i<=100;i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题二
            //int sum = 0;
            //for (int i = 0;i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    { 
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("0到100之间的所有偶数和为：" + sum);
            #endregion

            #region 练习题三
            //for (int i = 100; i <= 999; i++)
            //{
            //    int bai = i / 100;
            //    int shi = (i / 10) % 10;
            //    int ge = i % 10;
            //    if(i == bai * bai * bai + shi * shi * shi + ge * ge * ge)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 练习题四
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}X{1}={2}  ",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}   
            #endregion

            #region 练习题五
            //for(int j = 0; j < 10; j++)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (j == 0 || j == 9)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (i == 0 || i == 9)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题六
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题七
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 10 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}