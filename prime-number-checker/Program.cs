// The default code.
using System;

namespace prime_number_checker {

    class Program {

        static void Main(string[] args) {

            try {

                // Getting the user input.
                Console.Write("Enter the number you want to check to be a prime number or not: ");
                string num = Console.ReadLine();
                int Num = int.Parse(num);

                int nonDivisibles = 0;

                // Calculating the output/
                if (Num > 1) {

                    for (int divisor = 2; divisor < Num; divisor ++) {

                        if (Num % divisor == 0) {

                            Console.WriteLine("The number is composite");
                            break;

                        } else nonDivisibles ++;

                    }

                    if (nonDivisibles == Num - 2) Console.WriteLine("The number is prime");

                // Making sure the user has entered a positive integer.
                } else Console.WriteLine("Please enter a positive number.");

            // If the user entered a string instead of an integer, this message is printed out instead of the program crashing.
            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            // Preventing the program from terminating immediately.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}