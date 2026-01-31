using System;
using System.Diagnostics;

namespace Lesson10_算数运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符");

            #region 知识点一：赋值符号
            // = 赋值符号
            // 关键知识点：
            //先看右侧 再看左侧 把右侧的值 赋值给左侧的变量
            string myName = "唐老师";
            int myAge = 18;
            float myHeight = 1.88f;

            #endregion

            #region 知识点二： 算术运算符

            #region + 加号
            // 用自己计算 先算右侧的结果 再赋值给左侧的变量
            int i = 1;

            i = i + 2;
            Console.WriteLine(i);
            //连续运算 先算右侧结果，再赋值给左侧变量

            i = 1 + 3 + 89 + i + i;
            Console.WriteLine(i);
            i = 1 + 2 + 3;
            Console.WriteLine(i);

            //初始化时就运算 先算右侧结果 再赋值给左侧变量

            int i2 = 1 + 3 + i;
            Console.WriteLine(i2);

            #endregion

            #region - 减号
            // 用自己计算 先算右侧的结果 再赋值给左侧的变量
            int j = 1;
            j = j - 5;
            Console.WriteLine(j);
            //连续运算 先算右侧结果，再赋值给左侧变量
            j = 1 - 2 - 3;
            Console.WriteLine(j);
            j = 1 - j;
            Console.WriteLine(j);
            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int j2 = 1 - j - 0;
            Console.WriteLine(j2);
            #endregion

            #region * 乘号
            //用自己计算 先算右侧的结果 再赋值给左侧的变量
            int c = 1;
            c = c * 10;
            Console.WriteLine(c);
            //连续运算 先算右侧结果，再赋值给左侧变量
            c = 1 * 2 * 3;
            Console.WriteLine(c);
            c = 2 * c * 2;
            Console.WriteLine(c);
            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int c2 = c * 2;
            Console.WriteLine(c2);
            #endregion

            #region / 除号
            //用自己计算 先算右侧的结果 再赋值给左侧的变量
            int chu = 1;
            chu = 10 / chu;
            Console.WriteLine(chu);
            //连续运算 先算右侧结果，再赋值给左侧变量

            //初始化时就运算 先算右侧结果 再赋值给左侧变量


            chu = 1;
            chu = 1 / 2;
            Console.WriteLine(chu);
            //默认整数是int 如果用来做除法运算 要注意 会丢失小数后的小数
            //如果你想用浮点数来存储 一定是 在运算时要有浮点数的特征
            float f = 1 / 2f;
            Console.WriteLine(f);

            #endregion

            #region % 取余
            //用自己计算 先算右侧的结果 再赋值给左侧的变量
            int y = 4;
            y = y % 3;
            Console.WriteLine(y);
            //连续运算 先算右侧结果，再赋值给左侧变量
            y = 4 % 3 % 2;
            Console.WriteLine(y);
            //初始化时就运算 先算右侧结果 再赋值给左侧变量

            #endregion

            #endregion

            #region 知识点三：算数运算符的优先级
            //优先级 是指 在混合运算时的运算顺序

            //乘除取余 的优先级 高于 加减法
            int a = 1 + 2 * 3 / 2 + 1;
            Console.WriteLine(a);

            a = 1 + 4 % 2 * 3 / 2 + 1;
            Console.WriteLine(a);
            //括号可以改变优先级 运算时 先算括号内的内容
            a = 1 + 4 %( 2 * 3 / 2) + 1;
            Console.WriteLine(a);

            //多组括号 先算最里层括号 依次往外算
            a = 1 + 4 % (2 * (3 / 2)) + 1;
            Console.WriteLine(a);

            #endregion

            #region 知识点四 复合运算符
            //固定写法
            //+= -= *= /= %=
            //复合运算符是用于 自己=自己进行运算
            int i3 = 1;
            i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 1;
            i3 += 2;//i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 2;
            i3 += 2;//4
            i3 -= 2;//i3 = i3 - 2;
            i3 *= 2;//4
            i3 /= 2;//1
            i3 %= 2;//0
            Console.WriteLine(i3);
            
            int i4 = 10;
            i4 += 20 * 2 / 10;
            Console.WriteLine(i4);

            //注意：复合运算符 只能进行一次运算 不能混合运算

            #endregion

            #region 知识点五 自增减运算符
            int a2 = 1;
            
            a2 = a2 + 1;
            a2 += 1;

            //自增运算符
            a2 = 1;
            a2++;//先用再加
            Console.WriteLine(a2);
            ++a2;//先加再用
            Console.WriteLine(a2);

            a2 = 1;
            Console.WriteLine(a2++);//先用后加
            Console.WriteLine(++a2);//现加再用


            #endregion
        }
    }
}
