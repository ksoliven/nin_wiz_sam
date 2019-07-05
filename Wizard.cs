using System;

namespace wiz_nin_sam
{
public class Wizard : Human
    {
        public Wizard(string n) : base(n)
        {   
        health= 50;
        Intelligence = 25;
        }  
        public void Heal()
        {
        health  += 10 *Intelligence;
        }  
        public void Fireball(object target)
        {
            Random randInt = new Random();
            Human victim = target as Human;
            victim.health -= randInt.Next(20, 51);
        }
        }
}