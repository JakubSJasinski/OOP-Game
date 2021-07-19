using System;

namespace LittleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Warrior warrior = new Warrior(1,"Jake", 100, 10, 7);

            Defender defender = new Defender("Jakub", 130, 90, 10);

            Fight fight = new Fight();
            fight.FightNow(warrior, defender);
            
        }
    }
}
