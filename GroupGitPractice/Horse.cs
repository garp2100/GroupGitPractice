using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitPractice
{
    internal class Horse: Pet
    {
        public int Age { get; set; }

        public Horse()
        {
            Name = "Tom the horse";
        }

        public override void MakeHappyNoise()
        {
            Console.WriteLine("Horse sounds");
        }
    }
}
