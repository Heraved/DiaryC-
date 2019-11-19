using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    public class Student
    {
        public static string name;
        public static string surname;
        public static int age;
       



        public static void info()
        {
            Console.WriteLine("Wprowadź imie studenta:");
            name = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwisko studenta:");
            surname = Console.ReadLine();
            Console.WriteLine("Podaj wiek studenta:");
            age = Convert.ToInt32(Console.ReadLine());

            

        }
        
    }
}
   
