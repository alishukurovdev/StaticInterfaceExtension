using StaticInterfaceExtension.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterfaceExtension.Model
{
    public class Student
    {
        static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set;
            //{
        //        return Name;
        //            } set {
        //        if(Name.Length>2) Name=value;
        //    }
            }
        public string Surname
        {get; set;
            //get { return Surname; }
            //set
            //{
            //    if(Surname.Length>4) Surname = value;
            //}
        }
        public Student(string name, string surname)
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Count++;
            Id= Count;
        }
        public void GetInfo() {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}");
        }
    }
}
