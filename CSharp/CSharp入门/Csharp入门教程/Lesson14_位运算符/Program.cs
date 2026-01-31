using System;

namespace Lesson1_位运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("位运算符");
            //位运算符 主要用数值类型进行运算
            //将数值转换为2进制 在进行位运算

            #region 知识点一 位与 &
            //规则 链接两个数值进行位计算 将数值转为2进制
            // 对位运算 有0则0
            int a = 1;//001
            int b = 5;//101
            //  001
            // &101
            //  001
            int c = a & b;
            Console.WriteLine(c);

            a = 3;       //011
            b = 19;    //10011
            c = a & b; //00011
            Console.WriteLine(c);//3 

            //多个数值进行位运算 没有括号时 从左到右 依次计算
            a = 1;   //001
            b = 5;   //101
            c = 19;//10011
            int d = a & b & c;//00001
            Console.WriteLine(d);//1

            a = 1;
            b = 2;
            Console.WriteLine(a & b);

            #endregion

            #region 知识点二 位或 |
            //规则 链接两个数值进行位计算 将数值转为2进制
            //对位运算 有1则1

            a = 1;
            b = 3;
            c = a | b;
            //   001
            // | 011
            //   011
            Console.WriteLine(c);//3

            a = 5;   //101
            b = 10; //1010
            c = 20;//10100
                   //11111
            Console.WriteLine(a | b | c);
            #endregion

            #region 知识点三 位异或 ^
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 相同为0 不同为1
            a = 1;//001
            b = 5;//101
                  //100
            Console.WriteLine(a ^ b);

            a = 10; // 1010
            b = 11; // 1011
                    //^0001
            c = 4;  // 0100
                    //^0101 
            Console.WriteLine(a ^ b ^ c);
            #endregion

            #region 知识点四 位取反 ~
            // 规则 写在数值前面 将数值转为2进制
            // 对位运算 0变1 1变0
            a = 5; // 0101
            c = ~a;// 1010  补码表示 -6
            Console.WriteLine(c);
            #endregion

            #region 知识点五 位移运算符 左移 右移
            //规则 让一个数的2进制进行左移和右移
            //左移几位 右侧加几个0
            a = 5;// 101
            c = a << 5;
            Console.WriteLine(c);

            //右移几位 右侧去掉几个数
            a = 5; //101
            c = a >> 2;
            Console.WriteLine(c);
            #endregion

            Console.WriteLine(35<<4);
            
            Console.WriteLine(66>>1);

            Console.WriteLine(99^33);
            Console.WriteLine(76|85);
        }
    }
}