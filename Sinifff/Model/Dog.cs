using Sinifff.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifff.Model
{
    class Dog : Domestic, ISwim
    {
        public Dog(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = 1;

        public override void Eat()
        {
            Console.WriteLine("Eating bone");
        }

        public void Swim()
        {
            Console.WriteLine("Dog Swim"); 
        }
    }
}
