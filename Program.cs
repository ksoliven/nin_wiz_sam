using System;

namespace wiz_nin_sam
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard kate = new Wizard("kate");
            Wizard gandalf = new Wizard("gandalf");
            // Console.WriteLine("Hello World!");
            Samurai shidoshi = new Samurai("Shidoshi");
            shidoshi.death_blow(kate);
            Console.WriteLine("kate health" + " " + kate.health);
            Ninja hayabusa = new Ninja("hayabusa");
            hayabusa.Steal(gandalf);
            Console.WriteLine("You have stolen from Gandalf's health" + gandalf.health);

        }
    }
}
