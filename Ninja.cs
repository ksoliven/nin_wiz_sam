using System;

namespace wiz_nin_sam
{
    public class Ninja : Human
    {
        public Ninja(string d) : base(d)
        {
            Dexterity = 175;
        }
        public void Steal(object target)
        {
            Human victim = target as Human;
            health += 10;
        }
        public void Get_Away()
        {
        health -= 15;
        }
    }
}