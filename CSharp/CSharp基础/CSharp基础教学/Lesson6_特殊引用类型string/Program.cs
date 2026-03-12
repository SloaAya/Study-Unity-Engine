using System;

namespace Lesson5_值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊引用类型string");
            #region 知识点一 复习值和引用类型
            //值类型-- 他变我不变 --存储在栈内存中
            // 无符号整形 有符号整形 浮点数 char bool 结构体

            //引用类型 -- 他变我也变 -- 存储在堆内存中
            //数组 string 类
            #endregion

            #region 知识点二 string
            //string str1 = "123";
            //string str2 = str1;
            //// string 非常的特殊 他具备 值类型的特征 他变我不变
            //str2 = "321";

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);


            #endregion

            string str1 = "123";
            string str2 = str1;
            // string 非常的特殊 他具备 值类型的特征 他变我不变
            str2 = "321";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}