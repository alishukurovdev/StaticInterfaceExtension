using StaticInterfaceExtension.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticInterfaceExtension.Extension
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static bool HasDigit(this string str)
        {
            return str.Any(Char.IsDigit);
        }
        public static bool CheckPassword(this string str)
        {
            return str.Any(Char.IsUpper)&&str.Any(Char.IsLower)&&str.Any(Char.IsDigit)&&str.Length > 8;
        }
        public static string Capitalize(this string txt)
        {
            return txt.Substring(0,1).ToUpper()+txt.Substring(1).ToLower();
        }
    }















//    1)Aşağıdakı extension metodlardan ibarət static Helper class-ı yaradın.

//IsOdd() - int deyerler üçün həmin obyektin tək ədəd olub olmadığını geri qaytaran(true/false) method
//IsEven() - int deyerler  üçün həmin obyektin cüt ədəd olub olmadığını geri qaytaran(true/false) method
//HasDigit() - string deyerler  üçün həmin obyektin daxilində digit character olub olmamasını geri qaytaran(true/false) metod
//CheckPassword() - string deyerlerini yoxluyub true/false qaytarir Password-da en azi bir boyuk bir kicik herf ve en azi 1 reqem olamilidir.Uzunlugu 8-den kicik olmamalidir.
//Capitalize() - String-lər üçün Capitalize adlı extention metod yaradırsınız.Bu metod string dəyərini capitalaize edib geri
//--------------------------------------------------------------------------------------------------------------------2)

//Student class-i yaradin
//        static Count
//        Id
//        Name(Capitalize olunmalidir)
//        Surname(Capitalize olunmalidir)
//        GetInfo()  butun melumatlari cixarir Countdan bashqa

//Group classi yaradin:
//       static Group[] Groups(Group arrayidir program.cs-de yaranan  butun gruplar bura elave olunmalidir)
//       static GroupCount(Unikal Id vermek ucun)
//       GroupId
//       GroupName
//       Student[] Students(her grupun oz telebeleri olur static deyil)
       
//      GetGroupInfo() Groupun melumatlarini ve grupdaki telebelerin Id Name ve Surname-i ekrana cixarir.
//    GetStudent() int id qebul edir o id-li studenti return edir eger gonderilen id ye aid student yoxdursa geriye null qaytarir.
//      AddStudent() Gonderilen Studenti Groupdaki Students Arrayina elave edir
//      Search() string qebul edir adinda ve ya soyadinda gonderilen string deyerleri olan telebelerin melumatlarini ekrana cixarir
//      ShowStudents() - Groupdaki telebeleri ekrana cixaran method
//      ToString() override edirsiz GroupId GroupName ve Telebelerin sayini geri qaytrir


//    static AddGroup() Group qebul edir Groups arrayina hemin Groupu elave edir
//    static RemoveGroup() Id qebul edir Groups arrayindan hemin id-li Groupu silir
//    static GetGroup()  int id qebul edir o id-li Groupu return edir eger gonderilen id ye aid Group yoxdursa geriye null qaytarir.

//QEYD: Her iki taski bir project-de yazin 1ci taskdaki Capitalize methoduna 2ci taskda ehtiyac olacaq
}





