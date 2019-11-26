using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    public class StudentsContainer
    {
        public static List<Student> ListofStudents = new List<Student>();
        public static List<float> ListofGrades = new List<float>();



        public static void CreateStudent()
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
        public static void AddGrades()
        {
            Console.WriteLine("Wprowadź imię studenta:");
            string consoleName = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwisko studenta:");
            string consoleSurname = Console.ReadLine();
            foreach (var student in ListofStudents)
            {
                if (student.name == consoleName && student.surname == consoleSurname)
                {
                    Console.WriteLine("Wprowadź oceny studenta");
                    student.grades = Console.Read();
                    ListofGrades.Add(student.grades);
                }
            }
        }
        public static void PrintAllStudents()
        {
            foreach (var student in ListofStudents)
            {

                Console.WriteLine(student.name + " " + student.surname + " " + student.age);
                

            }
            foreach (var student in ListofStudents)
            {
                foreach (var grades in ListofGrades)
                {
                    Console.WriteLine("\n" + student.grades);
                }
            }
            Console.ReadKey();
            
        }
    }
}


