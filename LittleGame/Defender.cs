using System;
using System.Collections.Generic;
using System.Text;

namespace LittleGame
{
    class Defender: Character
    {
        Random rand = new Random();
        
        public Defender(string name, int hp, int attack, int defense) : base(name, hp, attack, defense)
        {
          
        }

        public new int DoAttack()
        {
            Attack = rand.Next(0, Attack);
            return Attack;
        }
        public new int DoDefense()
        {
            Defense = rand.Next(0, Defense) + 5;
            return Defense;
        }
    }
}
