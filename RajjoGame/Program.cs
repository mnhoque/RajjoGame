using System;
using System.ComponentModel;

namespace RajjoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to add or substract choose one.....");

            string choose = Console.ReadLine();

            if (choose == "add" || choose == "+")
            {
                add();
            }else if(choose=="subtract"|| choose == "-")
            {
                subtract();
            }
            

            Console.ReadKey();
        }

        public static int subtract()
        {
            int number = 0;
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            return number;
        }

        public static int add()
        {
            bool find = false;
            int numbers = 0;
            while (find == false)
            {
                Console.WriteLine("How many numbers you want to add");

                try
                {
                    numbers = int.Parse(Console.ReadLine());
                    find = true;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. Please enter a integer");

                }

            }

            int count = 1;
            int totalsum = 0;
            while (count <= numbers)
            {
                Console.WriteLine("Enter the {0} number to add ", count);
                try
                {
                    int enteredNumber = int.Parse(Console.ReadLine());
                    totalsum = totalsum + enteredNumber;
                    count = count + 1;

                }
                catch
                {
                    Console.WriteLine("Wrong format. Please enter a integer");
                }

            }
            Console.WriteLine("The total sum of {0} numbers are {1}", (count - 1), totalsum);
            return totalsum;
            
        }
    }
}
