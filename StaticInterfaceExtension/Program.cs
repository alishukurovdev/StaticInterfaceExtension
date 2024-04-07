using StaticInterfaceExtension.Extension;
using StaticInterfaceExtension.Model;

namespace StaticInterfaceExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            Console.WriteLine($"{num1} is odd: {num1.IsOdd()}");

            int num2 = 10;
            Console.WriteLine($"{num2}  is even:  {num2.IsEven()}");

            string str1 = "Ali44";
            Console.WriteLine($"{str1} has digit: {str1.HasDigit()}");

            string password = "Salam1234";
            Console.WriteLine($"{password} Password: {password.CheckPassword()}");

            Student std1 = new Student("aLik", "shUkuRov");    
            Student std2 = new Student("GaRib", "GariBzade");
            Student std3 = new Student("IBrahim", "XanKEndi");
            Student std4 = new Student("sAHin", "ALIzade");


            Group group1 = new Group("Ab106");
            group1.AddStudent(std1);
            group1.AddStudent(std2);
            Console.WriteLine();
            Group group2 = new Group("AP227");
            group2.AddStudent(std3);
            group2.AddStudent(std4);

            Group.AddGroup(group1);
            Group.AddGroup(group2);

            Console.WriteLine(group1); 
           Console.WriteLine(group2);
            group1.GetGroupInfo();


        }
    }
}
