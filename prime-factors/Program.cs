using System;

namespace prime_factors {

    class Program {

        static void Main(string[] args) {

            try {

                Console.Write("Enter the number you wnat to find the prime factors of: ");

                string num = Console.ReadLine();
                int Num = int.Parse(num);
                int num2 = Num;

                Console.WriteLine("The prime factors of" + num + "are-:\n");

                for (int smallerNum = 2; smallerNum <= Num; smallerNum ++) {

                    while (num2 % smallerNum == 0) {

                        Console.WriteLine("\t" + smallerNum);
                        num2 /= smallerNum;

                    }

                }

                if (num2 == Num) Console.WriteLine(num + " has no prime factor (except " + num + "itself)");

            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}