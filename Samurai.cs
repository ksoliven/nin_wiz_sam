using System;

namespace wiz_nin_sam
{
    public class Samurai : Human
    {
        public Samurai (string h) : base(h)
        {
            health = 200;
        }
        public void death_blow(Human victim)
        {
            if(victim.health <= 50)
            {
                victim.health = 0;
            }
        }
        public void Meditate()
        {
            health = 200;
        }
    }
}