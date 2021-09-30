// The default code.
using System;

namespace prime_factors {

    class Program {

        static void Main(string[] args) {

            try {

                // Getting the user input.
                Console.Write("Enter the number you wnat to find the prime factors of: ");

                string num = Console.ReadLine();
                int Num = int.Parse(num);
                int num2 = Num;

                Console.WriteLine("The prime factors of" + num + "are-:\n");

                // Calculating the ouput.
                for (int smallerNum = 2; smallerNum <= Num; smallerNum ++) {

                    while (num2 % smallerNum == 0) {

                        Console.WriteLine("\t" + smallerNum);
                        num2 /= smallerNum;

                    }

                }

                // Composite case.
                if (num2 == Num) Console.WriteLine(num + " has no prime factor (except " + num + "itself)");

            // If the user enters a string instead of an integer, this message is printed out instead of the program crashing iwht an error.
            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            // Preventing the eprogram from terminating immediately.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}