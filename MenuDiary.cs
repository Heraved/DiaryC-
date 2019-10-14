using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    class MenuDiary
    
    {
        public static void Menu()
        {
            Console.Title = "Witaj w elektronicznym dzienniku ocen!";
             
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Wpisz dane studenta");
                Console.WriteLine("2.Dodaj ocene");
                Console.WriteLine("3.Zmień dane");
                Console.WriteLine("4.Wyświetl listę studentów");
                Console.WriteLine("5.Wyjdź");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch(klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); StudentName(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); StudentAssessment(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); Changes(); break;
                    case ConsoleKey.D4:
                        Console.Clear(); ListofStudents(); break;
                    case ConsoleKey.D5:
                        Environment.Exit(0); break;

                    default: break;




                }

                 void StudentName()
                
                {
                    
                    Console.WriteLine("Wpisz dane studenta:");
                    string Student1; 
                    Student1 = Console.ReadLine();
                    Menu();

                    

                    Console.ReadKey();
                }
                
                 void StudentAssessment()
                {
             
                    
                }
                 void Changes()
                {

                }
                void ListofStudents()
                {

                }
                
            }
        }
    }
}
