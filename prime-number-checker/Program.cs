using System;

namespace prime_number_checker {

    class Program {

        static void Main(string[] args) {

            try {

                Console.Write("Enter the number you want to check to be a prime number or not: ");
                string num = Console.ReadLine();
                int Num = int.Parse(num);

                int nonDivisibles = 0;

                if (Num > 1) {

                    for (int divisor = 2; divisor < Num; divisor ++) {

                        if (Num % divisor == 0) {

                            Console.WriteLine("The number is composite");
                            break;

                        } else nonDivisibles ++;

                    }

                    if (nonDivisibles == Num - 2) Console.WriteLine("The number is prime");
                    
                } else Console.WriteLine("Please enter a positive number.");

            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}