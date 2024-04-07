using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifff.Model
{
    internal class Eagle : Bird
    {
        public Eagle(string name) : base(name)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Eagle hunting...");
        }
        public override void Eat()
        {
            Console.WriteLine("Eagle ate what it hunted");
        }
    }
}
