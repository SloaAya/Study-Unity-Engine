using System;

namespace 必备知识点_控制台相关
{

    class Program
    {
      static void Main(string[] args)
        {
            //Console.WriteLine("控制台相关");
            #region 知识点一 复习 输入输出
            //Console.WriteLine("123123");
            //Console.Write("12313554");

            //string str = Console.ReadLine();
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);
            #endregion

            #region 知识点二 控制台其他方法
            //1.清屏
            //Console.Clear();

            //2.设置控制台大小
            //窗口大小 缓冲区大小
            //注意：
            //1.先设置窗口大小，再设置缓冲区大小
            //2.缓冲区的大小不能小于窗口大小
            //3.窗口大小不能超过控制台的最大尺寸
            //窗口大小
            Console.SetWindowSize(100, 30);
            //缓冲区大小
            Console.SetBufferSize(120, 300);

            //3.设置光标位置
            //控制台左上角为(0,0)，右侧为X轴，下侧为Y轴 它是一个平面二维坐标系
            //注意：
            //1.边界问题
            //2.横纵距离单位不同 1y = 2x
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("HelloWorld");

            //4.设置颜色相关
            //文字颜色设置
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HelloWorld");
            Console.ForegroundColor = ConsoleColor.Green;
            //背景颜色设置
            Console.BackgroundColor = ConsoleColor.Yellow;
            //更改背景色后需要清屏才能看到效果
            Console.Clear();

            //5.光标显隐
            Console.CursorVisible = false;
            
            //6.关闭控制台
            Environment.Exit(0);
            #endregion
        }
    } 
}
