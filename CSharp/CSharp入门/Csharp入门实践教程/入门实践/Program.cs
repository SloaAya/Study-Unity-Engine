using System;
using System.Xml;

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
            string gamerOverInfo = "";//结束场景显示文字
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

                        #region 玩家属性相关
                        int playerX = 4;
                        int playerY = 5;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //检测玩家输入的变量
                        char playerInput;
                        #endregion

                        #region 公主属性
                        int princessX = 24;
                        int princessY = 5;
                        string princessIcon = "◆";
                        ConsoleColor princessColor = ConsoleColor.Blue;
                        #endregion

                        #region 玩家战斗相关
                        //记录是否在战斗中
                        bool isFight = false;
                        //用于跳出while循环
                        bool isOver = false;
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
                            #region 公主相关
                            else
                            {
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princessColor;
                                Console.Write(princessIcon);
                            }
                            #endregion

                            //画出玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            //等待玩家输入
                            playerInput = Console.ReadKey(true).KeyChar;
                            //战斗状态下
                            #region 战斗状态
                            if (isFight)
                            {
                                //如果战斗状态下
                                //只处理J键
                                if (playerInput == 'J' || playerInput == 'j')
                                {
                                    //判断 玩家或boss是否死亡
                                    if (playerHp <= 0)
                                    {
                                        //游戏结束
                                        nowSceneID = 3;
                                        gamerOverInfo = "游戏失败";
                                        break;
                                    }
                                    else if (bossHp <= 0)
                                    {
                                        //营救公主
                                        //boss擦除
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write("  ");
                                        isFight = false;
                                    }
                                    else
                                    {
                                        //去处理按J键打架
                                        //玩家打怪物
                                        Random r = new Random();
                                        int atk = r.Next(playerAtkMin, playerAtkMax);
                                        bossHp -= atk;
                                        //打印信息
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //先擦除上次显示的内容
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                            ");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("你对boss造成了{0}，boss剩余血量为{1}", atk, bossHp);

                                        //怪物打玩家
                                        if (bossHp > 0)
                                        {
                                            atk = r.Next(bossAtkMin, bossAtkMax);
                                            playerHp -= atk;

                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                            ");

                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("很遗憾，你未能战胜boss");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("boss对你造成了{0}，你剩余血量为{1}", atk, playerHp);
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                            ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                            ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                            ");

                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("你战胜了boss,快去营救公主");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("前往公主身边，按J键继续");

                                        }
                                    }
                                }
                            }
                            #endregion

                            else
                            {
                                #region 玩家移动相关
                                //擦除
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write("  ");
                                //改位置
                                switch (playerInput)
                                {
                                    case 'W':
                                    case 'w':
                                        --playerY;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            ++playerY;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp < 0)
                                        {
                                            ++playerY;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX += 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp < 0)
                                        {
                                            playerX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        ++playerY;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            --playerY;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp < 0)
                                        {
                                            --playerY;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX -= 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp < 0)
                                        {
                                            playerX -= 2;
                                        }
                                        break;
                                    case 'J':
                                    case 'j':
                                        //开始战斗
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            isFight = true;
                                            //可以开始战斗
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("你向Boss发起了攻击！          ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("玩家当前血量为{0}", playerHp);
                                            Console.Write("Boss当前血量为{0}", bossHp);
                                        }
                                        //判断是否再公主身边
                                        else if((playerX == princessX && playerY == princessY - 1 ||
                                            playerX == princessX && playerY == princessY + 1 ||
                                            playerX == princessX - 2 && playerY == princessY ||
                                            playerX == princessX + 2 && playerY == princessY) && bossHp < 0)
                                        {
                                            //改变场景ID
                                            nowSceneID = 3;
                                            gamerOverInfo = "游戏通关";
                                            //跳出循环
                                            isOver = true;
                                            break;
                                        }
                                        break;
                                }
                                #endregion
                            }
                            //外层while循环逻辑
                            if (isOver)
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        #region 结束场景
                        Console.Clear();
                        //标题内容
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");
                        //可变内容
                        Console.SetCursorPosition(w / 2 - 4, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(gamerOverInfo);


                        int nowSelEndIndex = 0;
                        while (true)
                        {
                            bool isQuiteEndWhile = false;

                            Console.SetCursorPosition(w / 2 - 6, 9);
                            Console.ForegroundColor = nowSelEndIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");
                            Console.SetCursorPosition(w / 2 - 4, 11);
                            Console.ForegroundColor = nowSelEndIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelEndIndex;
                                    if (nowSelEndIndex < 0)
                                    {
                                        nowSelEndIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelEndIndex;
                                    if (nowSelEndIndex > 1)
                                    {
                                        nowSelEndIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelEndIndex == 0)
                                    {
                                        nowSceneID = 1;
                                        isQuiteEndWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuiteEndWhile)
                            {
                                break;
                            }
                        }
                        break;
                        #endregion
                }

                #endregion
            }
        }
            
    }
}
