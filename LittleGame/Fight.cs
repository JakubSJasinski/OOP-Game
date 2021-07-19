using System;
using System.Collections.Generic;
using System.Text;

namespace LittleGame
{
    class Fight
    {
        Random rand = new Random();
        int player = 1;
        public void StartFight(Warrior att1, Warrior att2)
        {
            int Attack = att1.DoAttack();
            //att1.Attack = att1.DoAttack();
            int Defense = att2.DoDefense();
            Console.WriteLine("DoDefense is {0} and attack is {1}",Defense, Attack);
            if (att2.HP > 0)
            {
                att2.HP -= (att1.Attack - att2.Defense);
            }
         
        }

        public void FightNow(Warrior att1, Warrior att2)
        {
            while (true)
                if ((player == 1) && (att2.HP > 0))
                {
                    StartFight(att1, att2);
                    Console.WriteLine("HP of:{0} = {1}", att2.Name, att2.HP);
                    player = 2;
                }
                else if ((player == 2) && (att1.HP > 0))
                {
                    StartFight(att2, att1);
                    Console.WriteLine("Attacker {0} attacks for{1}",att2.Name,att2.Attack);
                    Console.WriteLine("HP of:{0} = {1}",att1.Name,att1.HP);
                    player = 1;

                }
                else break;

            if (att1.HP <= 0) Console.WriteLine("Winner is {0}, ",att2.Name);
            if (att2.HP <= 0) Console.WriteLine("Winner is {0}, ", att1.Name);

        }
    }
}
 