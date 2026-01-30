using System;

namespace Lesson18_while语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while语句练习");

            #region 知识点一 作用
            //让顺序执行的代码 可以不停的循环执行某一代码块的内容
            //条件分支语句 是 让代码产生分支
            //循环语句 是 让代码可以被重复执行
            #endregion

            #region 知识点二 语法相关
            // bool类型变量 条件运算符 逻辑运算符
            //while (bool类型的值)
            //{
            //    //当满足条件时 就会执行while语句块中的内容
            //    //.......
            //    //.......
            //    //.......
            //    //.......
            //    //当代码逻辑执行完 会回到while语句处 继续判断条件是否满足
            //}
            //Console.WriteLine("主代码逻辑");

            //死循环
            //就不停的执行循环中的逻辑
            //死循环只有在目前我们学习 控制台程序时 会频繁使用
            //之后进入 Unity开发后 很少会使用死循环
            //1.可能因为内存问题 造成程序崩溃 闪退
            //2.造成程序卡死
            //while (true)
            //{
            //    Console.WriteLine("这是死循环");
            //}

            //计算一个为0的整形变量 让他只能累加1 不停的加到10为止
            //int i = 0;
            ////bool类型的值 还可以用逻辑运算符 && || ！
            //while (i < 10)
            //{
            //    ++i;               
            //}
            //Console.WriteLine(i);

            #endregion

            #region 知识点三 嵌套使用
            //int a = 0;
            //int b = 0;
            //while (a < 10)
            //{
            //    ++a;
            //    while (b < 10)
            //    {
            //        ++b;
            //    }
            //}

            //a = 0;
            //b = 0;
            //while (a<10)
            //{
            //    ++a;
            //    if (b < 10)
            //    {
            //        ++b;
            //    }
            //}

            //int a2 = 0;
            //while(a2 < 10)
            //{
            //    ++a2;
            //    //每次从外层循环进来
            //    //b2和上一次有没有关系？
            //    //切记 没有关系
            //    int b2 = 0;
            //    while (b2 < 10)
            //    {
            //        ++b2;
            //    }
            //}
            #endregion

            #region 流程控制关键字
            //作用：控制循环逻辑的关键词
            //break：跳出循环
            //while (true)
            //{
            //    Console.WriteLine("break之前的代码");
            //    break;
            //    Console.WriteLine("break之后的代码");
            //}
            //Console.WriteLine("跳出循环之后的代码");

            //int i = 0;
            //while(true)
            //{
            //    ++i;
            //    Console.WriteLine(i);
            //    if (i == 10)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(i);   
            //

            ////continue: 回到循环开始 继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue之前的代码");
            //    continue;
            //    Console.WriteLine("continue之后的代码"); 
            //}
            //Console.WriteLine("跳出循环之后的代码");

            //打印1到20之间的所有奇数
            //int i = 0;
            //while (i < 20)
            //{
            //    ++i;
            //    if (i % 2 != 0)
            //    { 
            //        Console.WriteLine(i);
            //        continue;
            //    }
            //}

            //注意： break 和 continue 主要是和循环配合使用的 和if语句无关
            //break 在 switch中的作用和while循环中的作用有异曲同工之妙

            while (true)
            {
                int a = 1;
                switch (a)
                {
                    default:
                        continue;
                        break;
                }
                Console.WriteLine("11111");
            }
            #endregion

        }
    }

}

          