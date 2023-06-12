using System;
using System.Collections.Generic;

namespace Keywords
{
    internal interface IExample
    {
        void DoSomething();
    }

    sealed class ExampleClass : IExample
    {
        public void DoSomething()
        {
            Console.WriteLine("I Am Interface");
        }
    }

    public abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is: {x + y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is: {x - y}");
        }

        public abstract void Mul(int x, int y);

        public abstract void Div(int x, int y);
    }

    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is: {x * y}");
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is: {x / y}");
        }

        public string StudentName { get; set; }
    }

    class Program
    {
        public static void Change(AbsChild std3, int std1, ref int refId, out int outId)
        {
            std3.StudentName = "Ajith";
            std1 = 100;
            refId = 300;
            outId = 500;
        }

        static void Main(string[] args)
        {
            // Interface
            IExample example = new ExampleClass();
            example.DoSomething();

            AbsChild absChild = new AbsChild();
            absChild.Add(10, 5);
            absChild.Sub(10, 5);
            absChild.Mul(10, 5);
            absChild.Div(10, 2);

            // Ref and out
            int std2 = 200;
            absChild.StudentName = "Vijay";
            int refId = 400;
            int outId;

            Change(absChild, std2, ref refId, out outId);
            Console.WriteLine(absChild.StudentName);
            Console.WriteLine(std2);
            Console.WriteLine("Reference: "+refId);
            Console.WriteLine("Out: "+outId);

            // Break and continue
            Console.WriteLine("\nBreak:");
            for (int a = 1; a <= 5; a++)
            {
                if (a == 3)
                    break;

                Console.WriteLine(a);
            }

            Console.WriteLine("\nContinue:");
            for (int b = 1; b <= 5; b++)
            {
                if (b == 3)
                    continue;

                Console.WriteLine(b);
            }

            // Switch and case
            Console.WriteLine("\nSwitch and case");
            string str = "C#";
            switch (str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It's a Programming Language");
                    break;
                case "MSSQL":
                case "MySQL":
                    Console.WriteLine("It's a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It's a Framework");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            // Try, catch, and finally
            Console.WriteLine("\ntry, catch, and finally");
            try
            {
                int dividend = 10;
                int divisor = 0;
                int result = dividend + divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Console.Write("\nEnter the first number: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int nums = int.Parse(Console.ReadLine());

                int result = num + nums;
                Console.WriteLine("The sum is: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }
            finally
            {
                Console.WriteLine("Finally block!");
            }

            // For, do-while, while, foreach
            Console.WriteLine("\nfor, do-while, while, foreach");

            Console.WriteLine("For loop");
            int num1 = 0;

            for (num1 = 0; num1 < 5; num1++)
            {
                Console.WriteLine("Number: " + num1);
            }

            Console.WriteLine("While Loop");
            int num2 = 0;
            while (num2 < 5)
            {
                Console.WriteLine("Number: " + num2);
                num2++;
            }

            Console.WriteLine("Do While Loop");
            int num3 = 0;
            do
            {
                Console.WriteLine("Number: " + num3);
                num3++;
            } while (num3 < 5);

            Console.WriteLine("ForEach");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine("Number: " + num);
            }

            // If, else if, else
            Console.WriteLine("\nif, else if, else");
            int i = 20;
            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else if (i == 15)
            {
                Console.WriteLine("i is 15");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is 20");
            }
            else
            {
                Console.WriteLine("i is not present");
            }

            // Goto
            Console.WriteLine("\nGoto statement");
            string password = "123";
            string userInput;
            int attempts = 0;

        start:
            Console.Write("Enter the password: ");
            userInput = Console.ReadLine();

            if (userInput != password)
            {
                Console.WriteLine("Invalid password. Try again.");
                attempts++;
                if (attempts < 3)
                {
                    goto start;
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            else
            {
                Console.WriteLine("Access granted!");
            }

            // is and as keywords
            Console.WriteLine("\nIs and As keywords");
            object obj1 = "Hello";
            object obj2 = 123;

            if (obj1 is string)
            {
                string str1 = obj1 as string;
                Console.WriteLine("obj1 is a string: " + str1);
            }
            else
            {
                Console.WriteLine("obj1 is not a string");
            }

            if (obj2 is int)
            {
                int number = (int)obj2;
                Console.WriteLine("obj2 is an integer: " + number);
            }
            else
            {
                Console.WriteLine("obj2 is not an integer");
            }

            List<object> objList = new List<object> { "Vijay", 123, true };
            foreach (var item in objList)
            {
                string strItem = item as string;
                if (strItem != null)
                {
                    Console.WriteLine("List item: " + strItem);
                }
                else
                {
                    Console.WriteLine("null");
                }
            }

            // Checked and unchecked
            Console.WriteLine("\nChecked and Unchecked");
            try
            {
                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine("Checked Integer: " + (val + 2));
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow occurred (checked): " + ex.Message);
            }

            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine("Unchecked Integer: " + (val + 2));
            }

        }
    }
}
