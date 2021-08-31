using System;

namespace power {

    class Program {

        static void Main(string[] args) {

            try {

                Console.Write("Enter the number you want to find the power of: ");
                string num = Console.ReadLine();
                int intNum = int.Parse(num);
                int Num = intNum;

                Console.Write("Enter the power that you want to find: ");
                string power = Console.ReadLine();
                int Power = int.Parse(power);

                int i = 0;
            
                while (i < Power - 1) {

                    Num *= intNum;

                    i ++;

                }

                Console.WriteLine(num + " ^ " + power + " is " + Num);

            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}