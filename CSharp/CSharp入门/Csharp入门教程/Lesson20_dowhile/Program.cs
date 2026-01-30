using System;

namespace Lesson20_dowhile语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本语法
            //while循环 是先判断条件再执行
            //do while循环 是先执行再判断条件
            //do
            //{
            //do while 循环语句块
            //} while (bool类型);
            // 注意 do while 语句末尾有分号
            #endregion

            #region 实际使用
            //do
            //{
            //    Console.WriteLine("do while 循环语句块");
            //}while (false);

            //int a = 1;

            //do
            //{
            //    Console.WriteLine(a);
            //    ++a;
            //} while (a < 2);

            #endregion

            #region 嵌套使用
            do
            {
                if (true)
                {

                }
                while (true)
                {

                }
            } while (true);
            #endregion

        }
    }
}