using Sinifff.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifff.Model
{
    abstract class Fish : Animal, ISwim
    {
        public Fish(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = -1;

        public virtual void Swim()
        {
            Console.WriteLine("Fish Swimming");
        }
    }
}
