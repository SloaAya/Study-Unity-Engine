using System;

namespace Lesson13_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型 进行逻辑运算

            #region 知识点一 逻辑与
            //符号 &&
            //规则 对两个bool值进行逻辑运算 有假则假 同真则真

            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);
            result = false && false;
            Console.WriteLine(result);

            //bool相关的类型 bool 条件运算符
            //逻辑运算符优先级 低于 条件运算符 算术运算
            //true && true
            result = 3 > 1 && 1 < 2;
            Console.WriteLine(result);

            int i = 3;
            result = i > 1 && i < 5;
            Console.WriteLine(result);

            //多个逻辑与 组合运用
            int i2 = 5;

            result = i2 > 1 && i2 < 5 && i < 5;
            Console.WriteLine(result);


            #endregion

            #region 知识点二 逻辑或
            //符号 ||
            //规则 对两个bool值进行逻辑运算 有真则真 同假则假
            result = true || false;
            Console.WriteLine(result);
            result = true || true;
            Console.WriteLine(result);
            result = false || true;
            Console.WriteLine(result);
            result = false || false;
            Console.WriteLine(result);

            result = 3 > 10 || 3 < 5;
            Console.WriteLine(result);

            int a = 5;
            int b = 11;
            result = a > 1 || b < 20 || a > 5;
            Console.WriteLine(result);

            //? && ?
            //? || ?
            //?可以是写死的bool变量 或者 bool值
            //还可以是 条件运算符相关


            #endregion

            #region 知识点三 逻辑非
            //符号 !
            //规则 对一个bool值进行取反 真变假 假变真

            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine(result);
            result = !!true;
            Console.WriteLine(result);
            //逻辑非的优先级较高
            result = !(3 > 2);
            Console.WriteLine(result);

            a = 5;
            result = !(a > 5);
            Console.WriteLine(result);
            #endregion

            #region 知识点四 混合使用优先级问题
            //规则 ！(逻辑非)优先级最高 &&(逻辑与)次之 ||(逻辑或)最低
            //逻辑运算符优先级 低于 算术运算符 条件运算符 (逻辑非除外)

            bool gamerOver = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver = true;

            result = gamerOver || hp <= 0 && !isDead || isMustOver;
            Console.WriteLine(result);


            #endregion

            #region 知识点五 逻辑运算符短路规则
            int i3 = 1;
            // || 有真则真
            // 只要 逻辑与或者逻辑或 左边满足了条件
            // i3 > 0 true
            // 只要满足条件 右边的内容对于我们来说 已经不重要
            result = i3 > 0 || ++i3 >= 1;
            Console.WriteLine(result);

            //false && i3 ++>1;抛弃后面不计算
            result = i3 < 0 && i3++ > 1;
            Console.WriteLine(result);
            #endregion

        }
    }
}