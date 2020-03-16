using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
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
            float numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            float numB = float.Parse(Console.ReadLine());

            //var for result
            float result = 0;

            //based on operator input, run the appropriate method on the two numbers
            if(operation == "add")
            {
                result = Add(numA, numB);
            }
            else if(operation == "subtract")
            {
                result = Subtract(numA, numB);
            }
            else if(operation == "multiply")
            {
                result = Multiply(numA, numB);
            }
            else if(operation == "divide")
            {
                result = Divide(numA, numB);
            }

            //write line with answer
            Console.WriteLine($"The answer is {result}");
            Main();
        }

        //addition function
        public static float Add(float x, float y)
        {
            //simple math to get the sum
            float result = x + y;
            return result;
        }

        //the other 3 functions work similarly

        //subtract function
        public static float Subtract(float x, float y)
        {
            float result = x - y;
            return result;
        }

        //subtract function
        public static float Multiply(float x, float y)
        {
            float result = x * y;
            return result;
        }

        //subtract function
        public static float Divide(float x, float y)
        {
            float result = x / y;
            return result;
        }
    }
}
