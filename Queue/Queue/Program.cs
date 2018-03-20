using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            var selection = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("*************               Menu                      *************");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("*****                                                         *****");
                Console.WriteLine("*****        Option: 1 (Add item)                            *****");
                Console.WriteLine("*****        Option: 2 (delete item)                           *****");
                Console.WriteLine("*****        Option: 3 (show the number of items in queue)     *****");
                Console.WriteLine("*****        Option: 4 (find an item)                          *****");
                Console.WriteLine("*****        Option: 5 (Display all of the items in the queue)  *****");
                Console.WriteLine("*****        options: 6 (exit)                                *****");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
                Console.WriteLine("Choose a number:");
                var t = Console.ReadLine();
                bool checkInput = int.TryParse(t, out selection);

                if (checkInput)
                {
                    switch (selection)
                    {
                        case 1:
                            actions.program1();
                            break;
                        case 2:
                            actions.program2();
                            break;
                        case 3:
                            actions.program3();
                            break;
                        case 4:
                            actions.program4();
                            break;
                        case 5:
                            actions.program5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Thanks for using the program");
                            break;
                        default:
                            Console.WriteLine($"You selected option {selection}");
                            Console.WriteLine("Press <Enter> to quit the program");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You didn't type in a number");
                    selection = 0;
                    Console.WriteLine("Press <Enter> to quit the program");
                    Console.ReadKey();
                }

                Console.WriteLine();

            } while (selection < 6);

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }

    }

    public class actions
    {
        static Queue q = new Queue();




        public static void program1()
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');
            Console.WriteLine("Current queue: ");

        }
        public static void program2()
        {
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {A}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {M}", ch);
        }

        public static void program3()
        {
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");
            Console.WriteLine();

        }
        public static void program4()
        {



        }
        public static void program5()
        {

        }
    }
}
