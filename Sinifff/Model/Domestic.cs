using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifff.Model
{
    abstract class Domestic : Animal
    {
        public Domestic(string name) : base(name)
        {
        }

        public void Pet()
        {
            Console.WriteLine("Being pet");
        }
    }
}
