// The default code.
using System;

namespace power {

    class Program {

        static void Main(string[] args) {

            try {

                // Getting the user input.
                Console.Write("Enter the number you want to find the power of: ");
                string num = Console.ReadLine();
                int intNum = int.Parse(num);
                int Num = intNum;

                Console.Write("Enter the power that you want to find: ");
                string power = Console.ReadLine();
                int Power = int.Parse(power);

                int i = 0;

                // Calculating hte result.
                while (i < Power - 1) {

                    Num *= intNum;

                    i ++;

                }

                Console.WriteLine(num + " ^ " + power + " is " + Num);

            // If the user enters a string instead of an integer, this message is printed out instead of the program crashing with an error.
            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            // Preventing the program from instantly terminating.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}