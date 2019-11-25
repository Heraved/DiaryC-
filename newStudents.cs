using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    public class NewStudents
    {
        public static List<Student> ListofStudents = new List<Student>();
        

        public static void CreateStudents()
        {
            
            Student newStudent = new Student();
            Console.WriteLine("Wprowadź imie studenta:");
            newStudent.name = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwisko studenta:");
            newStudent.surname = Console.ReadLine();
            Console.WriteLine("Wprowadź wiek studenta:");
            newStudent.age = Convert.ToInt32(Console.ReadLine());
            ListofStudents.Add(newStudent);
            
           
        }
        public static void PrintAllStudents()
        {
            foreach (var student in ListofStudents)
            {

             Console.WriteLine(student.name + " " + student.surname + " " + student.age);

            }

            Console.ReadKey();
        }

    }
}


