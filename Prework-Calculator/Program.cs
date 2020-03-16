using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get operation from user
            string operation = "";
            //this loop makes sure the user inputs a legitimate operation
            while(operation != "add" && operation != "subtract" && operation != "multiply" && operation != "divide")
            {
                Console.WriteLine("Please enter which operation (add, subtract, multiply, or divide) you want to do on two numbers");
                operation = Console.ReadLine().ToLower();
            }

            //get number inputs from user
            Console.WriteLine("Please enter the first number");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int numB = int.Parse(Console.ReadLine());

            //based on operator input, run the appropriate method on the two numbers
            if(operation == "add")
            {
                Add(numA, numB);
            }
            else if(operation == "subtract")
            {
                Subtract(numA, numB);
            }
            else if(operation == "multiply")
            {
                Multiply(numA, numB);
            }
            else if(operation == "divide")
            {
                Divide(numA, numB);
            }
        }

        //addition function
        public static void Add(int x, int y)
        {
            //simple math to get the sum
            int result = x + y;
            //writing result in console
            Console.WriteLine($"The sum of {x} and {y} is {result}");
        }

        //the other 3 functions work similarly

        //subtract function
        public static void Subtract(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"The difference of {x} and {y} is {result}");
        }

        //subtract function
        public static void Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"The product of {x} and {y} is {result}");
        }

        //subtract function
        public static void Divide(float x, float y)
        {
            float result = x / y;
            Console.WriteLine($"The quotient of {x} and {y} is {result}");
        }
    }
}
