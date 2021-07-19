using System;
using System.Collections.Generic;
using System.Text;

namespace LittleGame
{
    
    class Character
    {
        Random rand = new Random();
        public bool isAlive { get; set; } = true;
        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Character(int id, string name, int hp,int attack, int defense)
        {
            Id = id;
            Name = name;
            HP = hp;
            Attack = attack;
            Defense = defense;
        }
        public Character( string name, int hp, int attack, int defense)
        {
            
            Name = name;
            HP = hp;
            Attack = attack;
            Defense = defense;
        }

        public int DoAttack()
        {
            Attack = rand.Next(0, Attack);
            return Attack;
        }
        public int DoDefense()
        {
            Defense = rand.Next(0, Defense);
            return Defense;
        }

    }
}
