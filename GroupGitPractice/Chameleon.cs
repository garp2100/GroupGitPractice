using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitPractice
{
    internal class Chameleon : Pet
    {
        public Chameleon()
        {
            Name = "Chameleon";
        }

        public override void MakeHappyNoise()
        {
            Console.WriteLine("Chameleons don't make sounds");
        }

    }
}
