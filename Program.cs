using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace EF_C_
{
    class Program
    {

        delegate void textcolor(string text);
        public static void colortext(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();

        }
        public static async Task threeding()
        {
            string dot = "...";
            Task dots = new Task(
                () =>
                {
                    for (int i = 0; i < dot.Length; i++)
                    {
                        Thread.Sleep(500);
                        Console.Write($"{dot[i]}");
                    }
                }
            );
            dots.Start();
            await dots;
        }
        public static async Task space()
        {
            Task spaces = new Task(
                () =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("");
                    }
                }
            );
            spaces.Start();
            await spaces;
        }
        public static void loading()
        {
            Console.Clear();
        }

        public static void Main(string[] args)
        {
            // Task Drop = ExecuteDatabase.DropDatabase();
            // Task Create = ExecuteDatabase.CreateDatabase();
            // Task.WaitAll(Create);
            int NumberOf,ID;
            A_Method_Students students = new A_Method_Students();
            string author = "PHI LÊ";
            bool status = true;
            do
            {
                Task sp = space();
                Task.WaitAll(sp);
                Console.WriteLine("\t\t\t\t                        Manager Application                 ");
                Console.WriteLine("\t\t\t\t------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t-                              MENU                        -");
                Console.WriteLine("\t\t\t\t-    1.SigIn                                               -");
                Console.WriteLine("\t\t\t\t-                                                          -");
                Console.WriteLine("\t\t\t\t-    2.SigUp                                               -");
                Console.WriteLine("\t\t\t\t-                                                          -");
                Console.WriteLine("\t\t\t\t-    3.Author                                              -");
                Console.WriteLine("\t\t\t\t-                                                          -");
                Console.WriteLine("\t\t\t\t-    0.Exit                                                -");
                Console.WriteLine("\t\t\t\t------------------------------------------------------------");
                textcolor texts;
                texts = colortext;
                Console.Write("\t\t\t\t                                                By: ");
                texts(author);
                Console.Write("\n\t\t\t\t Please enter your choice: ");
                string key = Console.ReadLine();
                //Check key is number or character?
                var result = int.TryParse(key, out _);
                if (result)
                {
                    switch (int.Parse(key))
                    {
                        case 1:
                            Console.Clear();
                            Task.WaitAll(sp);
                            Console.WriteLine("\t\t\t\t                      Manager Application                  ");
                            Console.WriteLine("\t\t\t\t------------------------------------------------------------");
                            Console.WriteLine("\t\t\t\t-                       Students                           -");
                            Console.WriteLine("\t\t\t\t-    1.Add lists                                           -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    2.Edit profile students                               -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    3.Delete students                                     -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    4.Search students with code number                    -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    5.Export data to excel                                -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    6.View lists students                                 -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    7.Teacher manager                                     -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t-    0.Back                                                -");
                            Console.WriteLine("\t\t\t\t-                                                          -");
                            Console.WriteLine("\t\t\t\t------------------------------------------------------------");
                            texts = colortext;
                            Console.Write("\t\t\t\t                                               By: ");
                            texts(author);
                            Console.Write("\n\t\t\t\t Please enter your choice: ");
                            string key_ST = Console.ReadLine();
                            //check key_ST is number? 
                            var result_ST = int.TryParse(key_ST, out _);
                            if (result_ST)
                            {
                                switch (int.Parse(key_ST))
                                {
                                    case 1:
                                        
                                        Console.Clear();
                                        Task.WaitAll(sp);
                                        Console.WriteLine($"\t\t\t\t\tEnter number of students:");
                                        NumberOf = Convert.ToInt32(Console.ReadLine());
                                        students.AddListStudents(NumberOf);
                                        break;
                                    default:
                                        Console.WriteLine("\t\t\t\tInvalid your selection!");
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Task.WaitAll(sp);
                                        Console.Write("\t\t\t\tEnter number code students: ");
                                        ID = int.Parse(Console.ReadLine());
                                        students.EditProfileStudents(ID);
                                        break;
                                }
                            }
                            break;
                        case 2:
                            //Sig Up
                            break;
                        case 3:
                            //Author
                            Console.Clear();
                            var Display_Author = new SortedList<string, string>();
                            Display_Author.Add("Full Name", "Lê Anh Phi");
                            Display_Author.Add("Mail", "leanhphi1706@gmail.com");
                            Display_Author.Add("Phone Number", "0933 310 5367");
                            foreach (var item in Display_Author)
                            {
                                Task.WaitAll(sp);
                                Console.WriteLine($"\t\t\t\t{item.Key}: {item.Value}");
                                Thread.Sleep(1500);
                            }
                            Console.Clear();
                            Task.WaitAll(sp);
                            Console.WriteLine("\t\t\t\tThanks you! See you again ^^!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 0:
                            status = false;
                            break;
                        default:
                            Console.WriteLine("\t\t\t\tInvalid your selection!");
                            break;
                    }

                }
            } while (status);

        }
    }
}
