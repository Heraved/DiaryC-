using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp2
{
    class MenuGradebook
       
    {
        public static void Menu()
        {
            Console.Title = "Witaj w elektronicznym dzienniku ocen!";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Wpisz dane studenta");
                Console.WriteLine("2.Dodaj ocene");
                Console.WriteLine("3.Dodaj kolejnego studenta");
                Console.WriteLine("4.Zmień dane");
                Console.WriteLine("5.Wyświetl wszystkich studentów");
                Console.WriteLine("6.Wyjdź");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); Student.info(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); Student.info(); break;
                    case ConsoleKey.D4:
                        Console.Clear(); break;
                    case ConsoleKey.D5:
                        Console.Clear(); AllStudents.Createlistofstudents(); break;
                    case ConsoleKey.D6:
                        Environment.Exit(0); break;

                    default: break;

                }

               
            }
        }
              
        }
            }
        
        

            

        
    

