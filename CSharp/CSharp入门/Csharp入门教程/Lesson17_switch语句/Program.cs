using System;

namespace Lesson17_switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句");
            #region 知识点一 作用
            //让顺序执行的代码 产生多分支
            #endregion

            #region 知识点二 基础语法
            //switch(变量)
            //{
            //    // 变量 == 常量 执行 case和break之间的代码
            //    case 常量:
            //        满足条件执行的代码逻辑;
            //        break;
            //    case 常量:
            //        break;
            //    case 可以有无数个
            //    default:
            //        都不满足时执行的代码逻辑;
            //        break;
            //}
            //注意： 常量！！只能写一个值 不能去写一个范围 不能写条件运算符 逻辑运算符
            //switch 值判断变量是否等于某一个固定值

            //int a = 3;
            //switch (a)
            //{
            //这个条件一定是常量
            //    case 1:
            //        Console.WriteLine("a等于1");
            //        break;
            //    case 2:
            //        Console.WriteLine("a等于2");
            //        break;
            //    case 3:
            //        Console.WriteLine("a等于3");
            //        break;
            //    default:
            //        Console.WriteLine("都不满足");
            //        break;
            //}

            //float f = 1.4f;
            //配合枚举使用
            //switch(f)
            //{
            //    case 1.5f:
            //        Console.WriteLine("f等于1.5");
            //        break;
            //    default:
            //        Console.WriteLine("f不等于1.5");
            //        break;
            //}

            #endregion

            #region 知识点三 default可以省略
            //string str = "123";
            //switch (str)
            //{
            //    case "123":
            //        Console.WriteLine("等于123");
            //        break;
            //    case "234":
            //        Console.WriteLine("等于234");
            //        break;
            //}
            #endregion

            #region 知识点四 可自定义常量
            //char c = 'A';
            ////1.必须初始化 2.不能修改
            //const char c2 = 'A';
            //switch (c)
            //{
            //    case c2:
            //        Console.WriteLine("c等于A");
            //        break;
            //}
            #endregion

            #region 知识点五 贯穿
            //作用 满足某些条件时 做的事情是一样的 就可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                //不写case后面配对的break 就叫贯穿
                //满足1时 都会执行同样的代码逻辑
                case 1:
                case 2:
                    //case 和 break 之间可以写n句语句
                    // 并且可以嵌套使用 if switch语句
                    Console.WriteLine("是个数字");
                    break;
                default:
                    break;
            }

            #endregion

        }
    }
}