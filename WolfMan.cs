using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class WolfMan : Wolf, IPerson

    {
        public WolfMan(string name, double weight, int age, bool isDomesticated) : base(name, weight, age, isDomesticated)
        {
           
        }

        public override void DoSound()
        {
            Console.WriteLine("The Wolfman is screaming");
        }

        public override string Stats()
        {
            var temp = base.Stats();
            return temp;
        }

        public void Talk()
        {
            Console.WriteLine("I am a wolfman");
        }
    }
}
