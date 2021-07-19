using System;

namespace LittleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Warrior warrior = new Warrior(1,"Jake", 100, 10, 7);
            warrior.ShowAttributes();
            Warrior warrior2 = new Warrior(2,"Jake", 1000, 30, 20);
            
            Warrior warrior3 = new Warrior(3,"Jake", 1000, 30, 20);
            
            Warrior warrior4 = new Warrior("Jake", 1000, 30, 20);
           
            Warrior warrior5 = new Warrior("Jasion", 100, 10, 4);

            Fight fight = new Fight();
            fight.FightNow(warrior5, warrior);
            
        }
    }
}
