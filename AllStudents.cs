using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    public class AllStudents
    {

            public static void Createlistofstudents()
            {
                Student newStudent = new Student();
                List<Student> ListofStudents = new List<Student>();
                ListofStudents.Add(newStudent);
                foreach (var student in ListofStudents)
                {
                    Console.WriteLine(student);
                    
                }

            Console.ReadKey();

            }
            
        }
        
    }


