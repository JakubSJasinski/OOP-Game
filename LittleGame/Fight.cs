using System;
using System.Collections.Generic;
using System.Text;

namespace LittleGame
{
    class Fight
    {
        Random rand = new Random();
        static bool winner = false;
        
        public string StartFight(Warrior att1, Defender att2)
        {
            int Attack = att1.DoAttack();
            int Attack2 = att1.DoAttack();
            int Defense = att2.DoDefense();
            int Defense2 = att2.DoDefense();
            int Dmg1 = Attack - Defense;
            int Dmg2 = Attack2 - Defense2;
            Console.WriteLine("{2} Defense is {0} and attack is {1}",Defense, Attack,att1.Name);
            Console.WriteLine("{2} Defense is {0} and attack is {1}", Defense2, Attack2, att2.Name);

           
            if (Dmg1>1)
               {
                   att2.HP -= Dmg1;
               }
                
                if(att2.HP <=0)
            {
                Console.WriteLine("{0} has died", att2.Name);
                return "Game Over";
            }
            return "Fight Again";
            

        }

        public void FightNow(Warrior att1, Defender att2)
        {
            while (true)
            {
                if (StartFight(att1, att2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (StartFight(att1, att2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                Console.WriteLine("Game Over");
            }
        }
    }
}
 