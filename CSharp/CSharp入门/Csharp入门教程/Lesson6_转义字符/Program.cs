using System;

namespace Lesson6_转义字符 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符");
            #region 转义字符的使用
            //单引号 \'
            string str = "\'哈哈啊哈\'";
            Console.WriteLine(str);
            //双引号 \"
            str = "\"哈哈啊哈\"";
            Console.WriteLine(str);
            //换行 \n
            str = "哈哈啊哈\n哈哈啊哈";
            Console.WriteLine(str);
            //斜杠 \\
            str = "哈哈啊哈\\哈哈啊哈";
            Console.WriteLine(str);
            //了解
            //制表符 \t
            str = "哈哈啊哈\t哈哈啊哈";
            Console.WriteLine(str);
            //光标退格 \b
            str = "123\b123";
            Console.WriteLine(str);
            //空字符 \0
            str = "哈哈啊哈\0哈哈啊哈";
            Console.WriteLine(str);
            //警报音 \a
            str = "哈哈啊哈\a哈哈啊哈";
            Console.WriteLine(str);
            #endregion
            #region 取消转义字符
            //使用 @ 符号取消转义字符
            string str2 = @"哈哈啊哈\哈哈啊哈";
            Console.WriteLine(str2);
            #endregion

        }
    }
}