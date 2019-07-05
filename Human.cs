using System;

namespace wiz_nin_sam
{
public class Human
    {
        public string Name;
        public int Strength{get; set;}
        public int Intelligence{get; set;}
        public int Dexterity{get; set;}
        public int health{get; set;}

        // public int Health
        // {
        //     get { return health; }
        // }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= Strength *5;
            }
        }
    }
}