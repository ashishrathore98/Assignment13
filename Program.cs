// *********TASK 1************
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello World!!!");
//    }
//}
// *********TASK 2**********
//using System;
//namespace person
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter your name: ");
//            string userName = Console.ReadLine();
//            Console.WriteLine("Hello, " + userName + "");
//        }
//    }
//}
// **********TASK 3**********
//using System;

//namespace BasicCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter two integers:");
//            int num1 = int.Parse(Console.ReadLine());
//            int num2 = int.Parse(Console.ReadLine());
//            int sum = num1 + num2;
//            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
//            int diff = num1 - num2;
//            Console.WriteLine($"Subtraction: {num1} - {num2} = {diff}");
//            int product = num1 * num2;
//            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
//            if (num2 != 0)
//            {
//                double division = (double)num1 / num2;
//                Console.WriteLine($"Division: {num1} / {num2} = {division}");
//            }
//            else
//            {
//                Console.WriteLine("Division by zero is not allowed.");
//            }
//            int modulus = num1 % num2;
//            Console.WriteLine($"Modulus: {num1} % {num2} = {modulus}");
//        }
//    }
//}
// ***********TASK 4*********************
//using System;

//namespace EvenOddChecker
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter an integer:");
//            string input = Console.ReadLine();
//            if (int.TryParse(input, out int number))
//            {
//                if (number % 2 == 0)
//                {
//                    Console.WriteLine($"{number} is an even number.");
//                }
//                else
//                {
//                    Console.WriteLine($"{number} is an odd number.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a valid integer.");
//            }
//        }
//    }
//}
// ********************TASK 5**********
//using System;

//namespace NumberPrinter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
// ***********TASK 6**********
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] myArray = { 10, 20, 30, 40, 50 };
//        int sum = 0;
//        foreach (int num in myArray)
//        {
//            sum += num;
//        }
//        double average = (double)sum / myArray.Length;
//        Console.WriteLine("Array elements: " + string.Join(", ", myArray));
//        Console.WriteLine("Sum of elements: " + sum);
//        Console.WriteLine("Average of elements: " + average);
//        Console.ReadKey();
//    }
//}
// **********TASK 7**********
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a positive integer: ");
//        int number = int.Parse(Console.ReadLine());

//        if (number >= 0)
//        {
//            long factorial = CalculateFactorial(number);
//            Console.WriteLine($"Factorial of {number} is: {factorial}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input! Please enter a positive integer.");
//        }
//        Console.ReadKey();
//    }
//    static long CalculateFactorial(int n)
//    {
//        if (n == 0 || n == 1)
//            return 1;

//        return n * CalculateFactorial(n - 1);
//    }
//}
// **********TASK 8***********
using System;

class Program
{
    static void Main()
    {
        int age = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            isValidInput = int.TryParse(input, out age);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
            }
        }

        if (age < 0)
        {
            Console.WriteLine("Invalid age. Age cannot be negative.");
        }
        else if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age <= 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior.");
        }
    }
}