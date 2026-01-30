using System;

namespace Lesson09_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 作用
            //将玩家输入的内容 存储string类型的变量中
            /*string str = Console.ReadLine();
            int i = int.Parse(str);*/

            //通过对异常捕获的学习 可以避免当代码报错时 造成程序卡死

            #endregion

            #region 基本语法

            try
            {
                //希望进行异常捕获的代码块
                //放到try语句块中
                //如果try中的代码 报错了 不会让程序卡死
            }
            catch
            {
                //(Exception e) 报错跟踪 获得报错信息
                //如果出错了 会执行 catch中的代码 来捕获异常
            }
            //可选部分
            finally
            { 
                //最后执行的代码 不管有没有出错 都会执行其中的代码
            }
            //中医： 异常捕获代码的基本结构中 不需要加;
            #endregion

            #region 实践
            try
            {
               string str = Console.ReadLine();
               int i = int.Parse(str);
               Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("不符合规范");
            }
            finally
            {
                Console.WriteLine("实行结束");
            }
            #endregion
        }
    }
}
