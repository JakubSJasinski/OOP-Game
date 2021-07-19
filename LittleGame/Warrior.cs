using System;
using System.Collections.Generic;
using System.Text;


namespace LittleGame
{
    class Warrior:Character
    {
        Random rand = new Random();

        public Warrior(string name,int hp,int attack,int defense): base(name,hp,attack,defense)
        {
           
            Attack = attack + 2;
          

        }
        public Warrior(int id,string name, int hp, int attack, int defense) : base(id,name, hp, attack, defense)
        {
            

        }


        public void ShowAttributes ()
        {
            Console.WriteLine("Id: {0}, HP {1} Name: {2}, Attack:{3} Defense:{4}", base.Id, HP, Name, Attack, Defense);
        }

        public new int DoAttack()
        {
           return rand.Next(1, (int) this.Attack) ;
            
        }
        public new int DoDefense()
        {
            return rand.Next(1,(int) this.Defense);
        }
            
        
    }
}
