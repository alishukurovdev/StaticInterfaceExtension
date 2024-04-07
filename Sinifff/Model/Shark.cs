using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifff.Model
{
    class Shark : Fish
    {
        public Shark(string name) : base(name)
        {
        }
        public override void Swim()
        {
            Console.WriteLine("Shark swimming");
        }
        public override void Eat()
        {
            Console.WriteLine("Shark ate little fishes");
        }

        public void Sniff()
        {
            Console.WriteLine("Shark sniffed");
        }
    }
}
