using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    public class Student
    {
        public static string nameStudent;
        public static int assessment;

       

        public static void studentInput()
        {
            Console.WriteLine("Wprowadź dane studenta:");
            nameStudent = Console.ReadLine();

           
        }
        public static void studentAssessment()
        {
            Console.WriteLine("Wprowadź oceny studenta:");
            assessment = Convert.ToInt32(Console.ReadLine());
        }
        public static void showStudent()
        {
            
            Console.WriteLine(nameStudent + "\t" + assessment);
            Console.ReadKey();
            
        }
    }
}
