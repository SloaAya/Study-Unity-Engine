using System;

namespace Lesson22_for语句
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            //for(/*初始表达式*/;/*条件表达式*/;/*增量表达式*/)
            //{
            //    //for循环语句块
            //}
            //第一个空（初始表达式）：一般声明一个临时变量，用来计数用
            //第二个空（条件表达式）：循环继续的条件，一个bool类型表达式
            //第三个空（增量表达式）：每次循环结束后，临时变量的变化，一般是自增或自减

            //第一次进入循环时 才会调用 第一个空中的代码
            //每次进入循环前 都会调用 第二个空中的代码 进行判断
            for (int i = 0; i < 10 ; i++ )
            {
                Console.WriteLine(i);
                //每次循环结束后 会调用 第三个空中的代码
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //for (int i = 0, j = 0; i < 10 && j < 0,++i, j = j + 1)
            //{ 

            //}

            #endregion

            #region 知识点二 支持嵌套
            //for (int i = 0; i < 10; i++)
            //{ 
            //    for(int j = 0;j<10;j++)
            //    {
            //        Console.WriteLine(i + "_" + j);
            //    }
            //}
            #endregion

            #region 知识点三 特殊写法
            //for循环可以写死循环
            //for (; ; )
            //{
            //    Console.WriteLine("死循环");
            //}

            //int k = 0;
            //for (; k < 10;)
            //{
            //    ++k;
            //}

            //for (k = 0; ; ++k)
            //{ 
            //    if(k >=10)
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region 知识点四 对比while循环
            for(int i = 10;i<10;++i)
            {

            }

            int j = 0;
            while(j<10)
            {

                ++j;
            }
            #endregion


        }
    }
}