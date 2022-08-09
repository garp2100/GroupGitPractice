using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitPractice
{
    internal class Bengal : Pet
    {
        public Bengal()
        {
            Name = "Decimal the bengal";
        }
        public override void MakeHappyNoise()
        {
            Console.WriteLine("Cat sounds");
        }
    }
}
