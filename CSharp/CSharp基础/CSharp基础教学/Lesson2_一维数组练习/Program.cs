using System;

namespace Lesson2_一维数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //int[] arr1 = new int[100];
            //for (int i = 0; i < arr1.Length; i++)
            //{

            //    Console.WriteLine(arr1[i]);
            //}
            #endregion

            #region 练习题二
            //int[] arr1 = new int[100];
            //int[] arr2 = new int[100];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr1[i] = i;
            //    arr2[i] = arr1[i]*2;
            //    Console.WriteLine(arr2[i]);
            //}
            #endregion

            #region 练习题三

            //int[] array = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Random r = new Random();
            //    int k = r.Next(101);
            //    array[i] = k;
            //    Console.WriteLine(array[i]);
            //}

            #endregion

            #region 练习题四
            //int Sum = 0;

            //int[] array = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{

            //    Random r = new Random();
            //    int k = r.Next(100);

            //    array[i] = k;
            //    Sum += array[i];
            //    Console.WriteLine(array[i]);
            //}

            //int max = array[0];
            //int min = array[0];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];  
            //    }

            //    if (array[i] < min)
            //    {
            //        min = array[i]; 
            //    }
            //}

            //Console.WriteLine("最大值: "+max);
            //Console.WriteLine("最小值: "+min);
            //Console.WriteLine("总和："+Sum);
            //Console.WriteLine("平均："+Sum/array.Length);

            #endregion

            #region 练习题五
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0,101);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("*****************************");

            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    int temp = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = temp;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 练习题六
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(-10,11);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("**************************");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > 0)
            //    {
            //        array[i] += 1;
            //    }
            //    else if (array[i] < 0)
            //    {
            //        array[i] -= 1;
            //    }
            //    Console.WriteLine(array[i]);
            //}

            #endregion

            #region 练习题七
            //int[] array = new int[10];

            //try
            //{
            //    int min = 0;
            //    int max = 0;
            //    int sum = 0;
            //    int avg = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine("请输入{0}位同学成绩",i+1);
            //        array[i]=int.Parse(Console.ReadLine());
            //        if (i == 0)
            //        {
            //            min = array[i];
            //            max = array[i];
            //        }
            //        else 
            //        {
            //            if (min > array[i])
            //            {
            //                min = array[i];
            //            }
            //            if (max < array[i])
            //            {
            //                max = array[i];
            //            }
            //        }
            //        sum += array[i];
            //    }
            //    avg = sum / array.Length;

            //    Console.WriteLine("最高分{0}，最低分{1}，平均分{2}",min,max,avg);
            //}
            //catch 
            //{
            //    Console.WriteLine("请输入数字");
            //}



            #endregion

            #region 练习题八
            string[] strs = new string[25];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = i % 2 == 0 ? "■" : "□";
                //if (i % == 0)
                //{
                //    strs[i] = "■";
                //}
                //else
                //{
                //    strs[i] = "□";
                //}
            }
            for (int i = 0; i < strs.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(strs[i]);
            }
            #endregion
        }
    }
}