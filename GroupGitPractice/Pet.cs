using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitPractice
{
    internal abstract class Pet
    {
        public string Name { get; set; }

        public int  AverageAge { get; set; }

        public string VetRecord { get; set; }

        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
