using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    class Grades
    {
        public static int grades;

        public static void AddGrades()
        {

            Console.WriteLine("Wybierz studenta:");
            Console.WriteLine("Wprowadź oceny studenta:");
            grades = Console.Read();
        }




    }
}
