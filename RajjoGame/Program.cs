using System;

namespace RajjoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to add numbrs or substract numbers");

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
            int bigNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the secound number");
            int secondNumber = int.Parse(Console.ReadLine());

            if (bigNumber > secondNumber)
            {
                number = bigNumber - secondNumber;
                Console.WriteLine("The diference between {0} and {1} is {2} .", bigNumber, secondNumber, number);
            }
            else
            {
                Console.WriteLine("{0} number is bigger than {1}",secondNumber,bigNumber);
                while (secondNumber > bigNumber)
                {
                    Console.WriteLine("Enter the second number again");
                    secondNumber = int.Parse(Console.ReadLine());
                    if (bigNumber >= secondNumber)
                    {
                        number = bigNumber - secondNumber;
                        Console.WriteLine("The diference between {0} and {1} is {2} .",bigNumber,secondNumber,number);
                        break;
                    }
                }
            }

            
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
