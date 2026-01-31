using System;

namespace 必备知识点_控制台练习题
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            int x = 0;
            int y = 0;

            while (true)          
            {
                //Console.Clear();第一种清空之前信息的方式
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                char c = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                switch (c)
                {
                    case 'W':
                    case 'w': 
                        y -= 1;
                        //改变位置后 判断新位置 是否越界
                        if (y<0)
                        {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }
        }
    }
}
