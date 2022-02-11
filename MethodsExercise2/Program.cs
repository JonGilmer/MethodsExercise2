using System;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition: ");
            Add(20, 4);
            Console.WriteLine("Subtraction: ");
            Subtract(4, 5);
            Console.WriteLine("Multiplication: ");
            Multiply(12, 12);
            Console.WriteLine("Division: ");
            Divide(200, 2);
            Console.WriteLine("Modulus: ");
            Mod(22, 3);

        }
        // Addition Method
        public static int Add(int num1, int num2)
        {
            int addResult = num1 + num2;
            Console.WriteLine(addResult);
            return addResult;
        }

        // Subtract Method
        public static int Subtract(int num1, int num2)
        {
            int subtractResult = num1 - num2;
            Console.WriteLine(subtractResult);
            return subtractResult;
        }

        // Multiply Method
        public static int Multiply(int num1, int num2)
        {
            int multiplyResult = num1 * num2;
            Console.WriteLine(multiplyResult);
            return multiplyResult;
        }

        // Divide Method
        public static int Divide(int num1, int num2)
        {
            int divideResult = num1 / num2;
            Console.WriteLine(divideResult);
            return divideResult;
        }

        // Modulus Method
        public static int Mod(int num1, int num2)
        {
            int modResult = num1 % num2;
            Console.WriteLine(modResult);
            return modResult;
        }
    }
}
