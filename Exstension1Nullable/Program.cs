﻿using Exstension1Nullable.Enums;
using Exstension1Nullable.Extensies;

namespace Exstension1Nullable
{
     class Program
    {
        static void Main(string[] args)
        {
            //string txt = "salaM";
            //Console.WriteLine(txt.ToCaptalize()) ;
            //Console.WriteLine(5.Add(10));
            //   IsEven(null);
            //var a= Console.ReadLine();
            //   switch (a)
            //{
            //    case "Mondey":
            //        Console.WriteLine(Weekdays.Mondey);
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine(Weekdays.Tuesday);
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine(Weekdays.Wednesday);
            //        break;
            //    case "Thursday":
            //        Console.WriteLine(Weekdays.Thursday);
            //        break;
            //    case "Friday":
            //        Console.WriteLine(Weekdays.Friday);
            //        break;
            //    case "Saturday":
            //        Console.WriteLine(Weekdays.Saturday);
            //        break;
            //    case "Sunday":
            //        Console.WriteLine(Convert.ToInt32(Weekdays.Sunday));
            //        break;
            //}
            var a=Enum.GetValues(typeof(Roles));
            foreach (var item in a)
            {
                Console.WriteLine(Convert.ToInt32(item)+"-"+ item.ToString());
            }
            int input=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a.GetValue(input));
        }
        //static void IsEven(int? num)
        //{
        //    if (num==null) Console.WriteLine("num must be on nullable value");
        //    else Console.WriteLine(num%2==0);


        //    Console.WriteLine(num%2==0);
        //}
    }
}
