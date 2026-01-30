using System;

namespace Lesson2_变量
{
    class Progrm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            //折叠代码
            #region 字符类型
                //1.有符号的整型变量 是能存储 一定范围的正负数包含0的变量类型
                //sbyte -128~127
                sbyte a = -128;
                Console.WriteLine("sbyte变量sb中存储的值是:" + a);
                //int -21亿~21亿
                //short -32768~32767
                //long -900万兆~900万兆

                //2.无符号的整型变量 是能存储 一定范围的正数包含0的变量类型
                //byte 0~255
                //uint 0~42亿
                //ushort 0~65535
                //ulong 0~18百万兆

                //3.浮点型变量 是能存储小数的变量类型
                //float 7/8位有效数字    满位会往前进一位
                float f = 1.1111f;
                Console.WriteLine(f);
                //double 15/17位有效数字    满位会往前进一位
                //decimal 27/28位有效数字
                //4.特殊类型变量
                //bool 只能存储true和false,表示真假
                //char 只能存储一个字符
                char c = '唐';
                Console.WriteLine(c);
                //string 可以存储多个字符即字符串
                string str = "hello world123465是哦";
                Console.WriteLine(str);
            #endregion
            #region 多个相同类型变量同时申明
                int i2 = 1;
                float f2 = 1.1f;
                string str2 = "123";
                bool bo3 = true;

                int a1 = 1, b1 = 2 , c1 = 3 , d1 = 4;
                Console.WriteLine(a1);
                string s1 = "123", s2 = "456";
                Console.WriteLine(s1 + s2);
            #endregion
            #region 变量初始化相关
                int p2;
                Console.WriteLine(p2);
            #endregion
        }
    }
}
