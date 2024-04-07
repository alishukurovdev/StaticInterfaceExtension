using Sinifff.Interface;
using Sinifff.Model;

namespace Sinifff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };

            //foreach (var animal in animals)
            //{
            //    animal.Eat();            }
            //ISwim dog = new Dog("Toplan");
            //ISwim fish = new Shark("Akulaa");
            //ISwim[] swimmers=new ISwim[]{fish,dog}; 
            //foreach (var swimmer in swimmers) {
            //    swimmer.Swim();
            //}

            IDivide c=new Calculate();
            Console.WriteLine(c.Divide(1, 5));

        }


    }
}