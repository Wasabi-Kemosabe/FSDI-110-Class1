using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();

            /* string name = "Angelo Totanes";
            int age = 34;
            float something = 1.90f; // for any floating point (number with decimals)
            double somethingD = 1.90; // for a LOT of decimal places
            decimal price = 2.12m; // for currency/money
            bool crazy = true;

            Console.WriteLine("My name is: " + name); */
        }

        public IActionResult Homework()
        {
            int[] numbers = new int[200];
            for (int i = 0; i < 200; i++)
            {
                numbers[i] = i + 1;
            }
            int howMany = CountAndPrintOdds(numbers);
            System.Console.WriteLine(howMany);

            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("Homework");
            System.Console.WriteLine("*****************************");
            return Content("123");
        }

        private IActionResult Content(string v)
        {
            throw new NotImplementedException();
        }

        public int CountAndPrintOdds(int[] numbers)
        {
            int count = 0;

            // Print the odd numbers inside the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                // Decide if num is an odd number
                int res = num % 2;
                if (res != 0)
                {
                    System.Console.WriteLine(num);
                    count += 1;
                }
            }

            return count;
        }

        // Rules for Class Constructor
        /* 
        - Should have the same name as the class
        - It should not have a return type
        */

        public Program()
        {
            Console.WriteLine("I'm the constructor");
            int result = SayHello();
            Console.WriteLine(result);
            AnotherFunction(20);
            AnotherFunction(50);
            Loops();
            Task1(); // 0 3 6 9 12 15
            Arrays();
        }

        public int SayHello()
        {
            Console.WriteLine("Hello from a function");
            return 47;
        }

        public void AnotherFunction(int val)
        {
            if (val < 40)
            {
                Console.WriteLine("Lower than 40");
            }
            else
            {
                Console.WriteLine("Greater than 40");
            }
        }

        public void Loops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inside a loop - " + i);
            }

            int j = 0;
            do
            {
                System.Console.WriteLine("Inside a do-while loop - " + j);
                j = j + 1;
            }
            while (j < 10);

            int k = 0;
            while (k < 10)
            {
                System.Console.WriteLine("Inside a while loop - " + k);
                k = k + 1;
            }
        }

        public void Task1()
        {
            for (int i = 3; i < 16; i += 3)
            {
                System.Console.WriteLine("Inside task one - " + i);
            }
        }

        public void Arrays()
        {
            // delcare an array
            string[] name = new string[10];
            int[] numbers = new int[10];

            // add values
            name[0] = "Angelo";
            name[1] = "John";
            name[2] = "Mark";

            numbers[0] = 43;
            numbers[1] = 56;
            numbers[2] = 2;


            // read values from array
            System.Console.WriteLine(name[0]);

            // travel the name array with a loop
            System.Console.WriteLine("Start name array");
            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }

            // travel the numbers array with a loop
            System.Console.WriteLine("Start numbers array");
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }

        public interface IActionResult
        {
        }
    }
}