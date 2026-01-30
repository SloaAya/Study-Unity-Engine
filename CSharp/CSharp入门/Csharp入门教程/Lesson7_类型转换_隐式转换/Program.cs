using System

    namespace Lesson7_类型转换_隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换");
            #region 相同大类型之间的转换
            //有符号 long-> int -> short -> sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int -> long
            //大范围装入小范围
            l = i;
            //不能用小范围装入大范围
            //i = l;
            l = i;

            //无符号 ulong -> uint -> ushort -> byte

            //浮点数 decimal !-> double -> float
            //decimal 不能用于转换为其他类型
            //float 可以

            //特殊类型  bool char string   
            //不存在隐式转换

            #endregion
            #region 不同大类型之间的转换
            #endregion 
        }

    }
}
