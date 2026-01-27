using System;

namespace Lesson18_switch语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句练习");
            #region 练习题一
            //Console.WriteLine("请输入学生评价");
            //string pingjia = Console.ReadLine();
            //switch (pingjia)
            //{
            //    case "很兴奋":
            //        Console.WriteLine("A级 工资4500");
            //        break;
            //    case "很充实":
            //        Console.WriteLine("B级 工资4000");
            //        break;
            //    case "还好吧":
            //        Console.WriteLine("C级 工资3700");
            //        break;
            //    case "难理解":
            //        Console.WriteLine("D级 工资3500");
            //        break;
            //    case "枯燥乏味":
            //        Console.WriteLine("E级 工资3200");
            //        break;
            //}
            #endregion

            #region 练习题二
            //Console.WriteLine("请输入购买型号");
            //string xingHao = Console.ReadLine();
            //switch (xingHao)
            //{
            //    case "中杯":
            //        Console.WriteLine("购买成功，剩余五元");
            //        break;
            //    case "大杯":
            //        Console.WriteLine("购买成功，剩余三元");
            //        break;
            //    case "超大杯":
            //        Console.WriteLine("钱不够，请换其他型号");
            //        break;
            //}
            #endregion

            #region 练习题三
            //Console.WriteLine("请输入学生成绩");
            //int score = int.Parse(Console.ReadLine());
            //switch (score)
            //{
            //    case 100:
            //    case 99:
            //    case 98:
            //    case 97:
            //    case 96:
            //    case 95:
            //    case 94:
            //    case 93:
            //    case 92:
            //    case 91:
            //    case 90:
            //        Console.WriteLine("A");
            //        break;
            //    case 89:
            //    case 88:
            //    case 87:
            //    case 86:
            //    case 85:
            //    case 84:
            //    case 83:
            //    case 82:
            //    case 81:
            //    case 80:
            //        Console.WriteLine("B");
            //        break;
            //    case 79:
            //    case 78:
            //    case 77:
            //    case 76:
            //    case 75:
            //    case 74:
            //    case 73:
            //    case 72:
            //    case 71:
            //    case 70:
            //        Console.WriteLine("C");
            //        break;
            //    case 69:
            //    case 68:
            //    case 67:
            //    case 66:
            //    case 65:
            //    case 64:
            //    case 63:
            //    case 62:
            //    case 61:
            //    case 60:
            //        Console.WriteLine("D");
            //        break;
            //    default: 
            //        Console.WriteLine("E");
            //        break;

            //}
            #endregion

            #region 练习题四
            try
            {
                Console.WriteLine("输入0~9的数字");
                int num = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                    default:
                        Console.WriteLine("输入正确范围");
                        break;
                }
            }
            catch 
            {

                Console.WriteLine("输入正确范围");
            }

            #endregion

        }
    }
}