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
        public static int grades;



        public static void info()
        {
            Console.WriteLine("Wprowadź imie studenta:");
            name = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwisko studenta:");
            surname = Console.ReadLine();
            Console.WriteLine("Podaj wiek studenta:");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public static void studentgrades()
        {
            Console.WriteLine("Wprowadź oceny studenta:, ");
            grades = Convert.ToInt32(Console.ReadLine());

        }
        public static void showStudent()
        {
            List <Student> ListofStudents = new List<Student>();
            ListofStudents.Add(name);
            ListofStudents.Add(surname);
            ListofStudents.Add(age);
        }
    }
}
   
