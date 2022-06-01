using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation (+/-/*//):");
            char operation = Convert.ToChar(Console.ReadLine());

            switch(operation)
            {
                case '+': Addition(numb1, numb2);
                    break;
                case '-': Subtraction(numb1, numb2);
                    break;
                case '*': Multiplication(numb1, numb2);
                    break;
                case '/': Division(numb1, numb2);
                    break;
            }
        }

        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"{a} - {b} = {result}");
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");
        }
        public static void Division(int a, int b)
        {
            double result = (double) a / (double) b;   //double - float 
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
