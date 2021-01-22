using System;

namespace MathOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my sum " + sum(2, 4));
            Console.WriteLine("This is Multiplication " + Multiply(10, 2));
            Console.WriteLine("Sum of three number " + sum1(2, 4, 6));
            Console.WriteLine("Sum of five number " + sum2(1, 1, 1, 1, 1));
        }
        public static int sum(int num1, int num2)
        {
            int addition1 = num1 + num2;
            return addition1;

        }
        public static int sum1(int num1, int num2, int num3)
        {
            int addition1 = num1 + num2 +num3;
            return addition1;

        }
        public static int sum2(int num1, int num2, int num3, int num4, int num5)
        {
            int addition1 = num1 + num2 + num3 + num4 + num5;
            return addition1;

        }
        public static int Multiply(int num1, int num2)
        {
            int multiplication = num1 * num2;
            return multiplication;

        }
      

        
    }
}
