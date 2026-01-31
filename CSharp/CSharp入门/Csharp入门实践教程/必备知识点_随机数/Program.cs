using System;

namespace 必备知识点_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");
            #region 知识点一 产生随机数对象
            //固定写法
            //Random 随机变量名 = new Random();
            Random r= new Random();
            #endregion

            #region 知识点二 生成随机数
            int i = r.Next();
            Console.WriteLine(i);

            i = r.Next(100);//0-99
            Console.WriteLine(i);

            i = r.Next(50, 100);//50-99
            Console.WriteLine(i);
            #endregion
        }
    }
}