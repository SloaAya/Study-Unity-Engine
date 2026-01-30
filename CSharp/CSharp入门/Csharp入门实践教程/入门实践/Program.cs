using System;

namespace 入门实践
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置

            //隐藏光标
            Console.CursorVisible = false;
            //设置舞台大小
            int w = 50;
            int h = 30;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 多个场景

            int nowSceneID = 1; //当前场景ID

            while (true)
            {

                //不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    case 1:
                        #region 开始场景
                        Console.Clear();

                        Console.SetCursorPosition(w / 2 - 7, 8);

                        Console.WriteLine("唐老师营救公主");
                        //当前选择的选项的编号
                        int nowSelIndex = 0;
                        //因为要输入 可以构造一个 开始界面自己的死循环
                        while (true)
                        {
                            bool isQuitWhile = false;
                            //显示内容
                            //先设置光标内容 再显示内容
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            //检测输入
                            //检测玩家 输入的一个键内容 并且不会再控制台上显示输入的内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //1.改变当前场景ID
                                        nowSceneID = 2;
                                        //2.要跳出当前循环
                                        isQuitWhile = true;
                                    }
                                    else if (nowSelIndex == 1)
                                    {
                                        //退出游戏
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                    case 2:
                        Console.Clear();
                        #region 背景绘制
                        //设置颜色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //绘制边框
                        for (int i = 0; i < w ; i+=2)
                        {
                            //上边框
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            //下边框
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                            //中间框
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");

                        }
                        ////下边框
                        //for (int i = 0; i < w ; i+=2)
                        //{
                        //    Console.SetCursorPosition(i, h-1);
                        //    Console.Write("■");
                        //}
                        ////中间墙
                        //for (int i = 0; i < w; i+=2)
                        //{
                        //    Console.SetCursorPosition(i, h - 6);
                        //    Console.Write("■");
                        //}

                        for (int i = 0; i < h; i++)
                        {
                            //左边框
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            //右边框
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        //右边框
                        //for (int i = 0; i < h; i++)
                        //{
                        //    Console.SetCursorPosition(w - 2, i);
                        //    Console.Write("■");
                        //}
                        #endregion
                        //游戏场景的死循环 专门用来 检测 玩家输入相关循环
                        #region boss属性相关
                        int bossX = 24;
                        int bossY = 15;
                        int bossAtkMin = 7;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        //申明一个 颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion
                        while (true)
                        {
                            #region boss相关
                            if (bossHp > 0)
                            {
                                //绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("场景三");
                        break;
                }
            }
        }
            #endregion

    }
}
