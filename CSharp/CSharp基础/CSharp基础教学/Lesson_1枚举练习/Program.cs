using System;
using System.Linq.Expressions;

namespace Lesson1_枚举
{
    //enum E_QType
    //{
    //    Onl,
    //    Inv,
    //    Off,
    //}
    enum E_cafeType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        M,
        /// <summary>
        /// 大杯
        /// </summary>
        B,
        /// <summary>
        /// 超大杯
        /// </summary>
        S,
    }

    enum E_Sex
    {
        Man,
        Woman,
    }

    enum E_Occupation
    {
        /// <summary>
        /// 战士
        /// </summary>
        Warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Master,
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 练习题一
            //E_QType QQType = E_QType.Onl;

            //Console.WriteLine("选择你的状态");
            //Console.WriteLine("1.在线");
            //Console.WriteLine("2.隐身");
            //Console.WriteLine("3.离线");

            //char input = Console.ReadKey(true).KeyChar;

            //switch (input)
            //{
            //    case '1':
            //        QQType = (E_QType)Enum.Parse(typeof(E_QType), "Onl");
            //        Console.WriteLine(QQType);
            //        break;
            //    case '2':
            //        QQType = (E_QType)Enum.Parse(typeof(E_QType), "Inv");
            //        Console.WriteLine(QQType);
            //        break;
            //    case '3':
            //        QQType = (E_QType)Enum.Parse(typeof(E_QType), "Off");
            //        Console.WriteLine(QQType);
            //        break;
            #endregion

            #region 练习题二
            //try
            //{
            //    Console.WriteLine("请输入咖啡种类（中杯0 大杯1 超大杯2）");
            //    int cafeType = int.Parse(Console.ReadLine());
            //    E_cafeType cType = (E_cafeType)cafeType;
            //    switch (cType)
            //    {
            //        case E_cafeType.M:
            //            Console.WriteLine("你购买了中杯，花费了35元");
            //            break;
            //        case E_cafeType.B:
            //            Console.WriteLine("你购买了大杯，花费了40元");
            //            break;
            //        case E_cafeType.S:
            //            Console.WriteLine("你购买了超大杯，花费了43元");
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确类型");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题三
            try
            {
                Console.WriteLine("请选择性别（男 0，女 1）");
                E_Sex sex = (E_Sex)int.Parse(Console.ReadLine());
                string sexStr = "";
                int atk = 0;
                int def = 0;
                switch (sex)
                {
                    case E_Sex.Man:
                        sexStr = "男性";
                        atk += 50;
                        def += 100;
                        break;
                    case E_Sex.Woman:
                        sexStr = "女性";
                        atk += 150;
                        def += 20;
                        break;
                }
                Console.WriteLine("请选择职业（战士 0 ，猎人 1 ， 法师2）");
                E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
                string skill = "";
                string occupation = "";
                switch (o)
                {
                    case E_Occupation.Warrior:
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        occupation = "战士";
                        break;
                    case E_Occupation.Hunter:
                        atk += 120;
                        def += 20;
                        skill = "假死";
                        occupation = "猎人";
                        break;
                    case E_Occupation.Master:
                        atk += 200;
                        def += 10;
                        skill = "奥数冲击";
                        occupation = "法师";
                        break;
                }
                Console .WriteLine("你选了\"{0}{1}\"，攻击力：{2}，防御力：{3}，职业技能：{4}",sexStr,occupation,atk,def,skill);
            }
            catch 
            {

                Console.WriteLine("请输入数字");
            }
            #endregion

        }

    }
}
