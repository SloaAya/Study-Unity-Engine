using System;

namespace 必备知识点_随机数练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            int defense = 10;
            int hp = 20;
            Random r = new Random();

            while (true)
            {
                int attack = r.Next(8, 13);
                if (attack < defense)
                {
                    hp -= 0;
                    Console.WriteLine("攻击力：" + attack);
                    Console.WriteLine("伤害不足");
                }
                else
                {
                    hp -= (attack - defense);
                    Console.WriteLine("攻击力：" + attack);
                    Console.WriteLine("造成的伤害：" + (attack - defense));
                    Console.WriteLine("剩余血量：" + hp);
                }
                if(hp <= 0)
                {
                    break;
                }

                Console.WriteLine("请按任意键继续");
                Console.ReadKey(true);
            }
            Console.WriteLine("击败");
        }
    }
}