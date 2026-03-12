using System;

namespace Lesson3_二维数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //int[,] array = new int[100,100];
            //int index = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = index;
            //        ++index;
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题二
            //int[,] array = new int[4, 4];
            //Random r = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (i <= 1 && j > 1)
            //        {
            //            array[i, j] = 0;
            //        }
            //        else
            //        {
            //            array[i, j] = r.Next(1, 101);
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题三
            //int[,] array = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 11);
            //        //对角线 元素 满足的条件
            //        if (i == j || i+j == 2)
            //        {
            //            sum += array[i, j];
            //        }
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习题四
            //int[,] array = new int[5,5];
            //Random r = new Random();
            ////记录最大值的行列号
            //int maxI = 0;
            //int maxJ = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{ 
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 501);
            //        Console.Write(array[i, j]+" ");
            //        //找最大值
            //        if (array[maxI, maxJ] < array[i,j])
            //        {
            //            maxI = i;
            //            maxJ = j;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("最大值为{0}，行{1}，列{2}", array[maxI, maxJ], maxI, maxJ);
            #endregion

            #region 练习题五
            int[,] array = new int[5, 5];
            Random r = new Random();
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 2);
                    if (array[i, j] == 1)
                    {
                        hang[i] = true;
                        lie[j] = true;
                    }
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                    {
                        array[i, j] = 1;
                    }
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine() ;
            }
            #endregion
        }
    }
}