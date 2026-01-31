using System;
using System.Linq.Expressions;

namespace Lesson8_类型转换_显示转换
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("类型转换");

            #region 括号强转
            // 作用 一般情况下 将高精度的类型强制转换为低精度的类型
            // 语法： 变量类型 变量名 = (变量类型) 变量值;
            // 注意： 精度问题 范围问题

            //相同大类的整形
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i = 1;
            long l = 1;

            //括号强转 可能会出现范围问题
            //s = i; //隐式转换
            s = (short)i; //显示转换
            Console.WriteLine(s);

            //无符号整形
            byte b = 1;
            uint ui = 1;
            b = (byte)ui; //显示转换

            //浮点之间
            float f = 1.1f;
            double d = 1.123465456487986541f;

            f = (float)d;

            Console.WriteLine(f);
            //无符号和有符号之间的转换
            uint ui2 = 1;
            int i2 = -1;
            //在强转时 一定要注意范围
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            i2 = (int)ui2; //强转时范围问题

            //浮点和整形之间的转换 浮点数强转成整形会直接丢掉小数
            i2 = (int)1.24f;
            Console.WriteLine(i2);//强转时范围问题

            //char 和整形之间的转换
            i2 = 'A';

            char c = (char)i2; //强转时范围问题
            Console.WriteLine(c);

            //bool和string不能通过括号强转

            #endregion

            #region Prase方法强转
            // 作用 将字符串转换为对应类型
            // 语法： 变量类型.Parse(字符串变量);
            // 注意： 字符串必须能够转换成对应类型，否则会抛出异常

            //有符号
            string str2 = "123";
            int i4 = int.Parse(str2); //将字符串转换为整形
            Console.WriteLine(i4);
            //字符串必须能够转换成对应类型，否则会抛出异常
            //i4 = int.Parse("123.45");
            //Console.WriteLine(i4);  
            //值的范围必须在对应类型的范围内
            short s3 = short.Parse("4");
            Console.WriteLine(s3);

            //无符号
            Console.WriteLine(byte.Parse("1"));
            Console.WriteLine(ushort.Parse("1"));
            Console.WriteLine(ulong.Parse("1"));
            Console.WriteLine(uint.Parse("1"));

            //浮点数
            float f3 = float.Parse("1.2323");
            double d3 = double.Parse("1.2323");

            //特殊类型
            bool b5 = bool.Parse("true");
            Console.WriteLine(b5);

            char c2 = char.Parse("A");
            Console.WriteLine(c2);
            #endregion

            #region Conver法
            //作用 更准确的将各个类型之间进行相互转换
            //语法 Convert.TO目标类型（变量或常量）
            //注意 填写的变量或常量必须正确 否则出错

            //转字符串 如果是把字符串转对应类型，那字符串一定要合法合规
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);
            // 精度比括号强转好 会四舍五入
            a = Convert.ToInt32(1.845458f);
            Console.WriteLine(a);//会自动去掉小数部分

            a = Convert.ToInt32(true);
            Console.WriteLine(a); //true转成1 false转成0
            a = Convert.ToInt32(false);
            Console.WriteLine(a);

            a = Convert.ToInt32('A'); //字符转成对应的ASCII码   
            Console.WriteLine(a); //65

            sbyte sb5 = Convert.ToSByte("1");
            short s5 = Convert.ToInt16("1");
            int i5 = Convert.ToInt32("1");
            long l5 = Convert.ToInt64("1");

            byte b6 = Convert.ToByte("1");
            ushort us5 = Convert.ToUInt16("1");
            uint ui5 = Convert.ToUInt32("1");
            ulong ul5 = Convert.ToUInt64("1");

            float f5 = Convert.ToSingle("1.23");
            double d5 = Convert.ToDouble("1.23");
            decimal de5 = Convert.ToDecimal("1.23");
            
            bool bo5 = Convert.ToBoolean("true");
            char c5 = Convert.ToChar("A");

            string str5 = Convert.ToString(123123123);
            #endregion

            #region 其他类型转string
            //作用：拼接打印
            //语法：变量类型.ToString();   

            string str6 = 1.ToString();
            str6 = true.ToString();
            str6 = 'A'.ToString();
            str6 = 1.23f.ToString();

            int aa = 1;
            str6 = aa.ToString(); //整形转字符串
            bool bo6 = true;
            str6 = bo6.ToString(); //布尔转字符串
            #endregion
        }
    }
}