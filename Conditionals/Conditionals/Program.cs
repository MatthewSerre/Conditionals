using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 1

            //Console.WriteLine("Enter a number between 1 and 10:");

            //var input = Console.ReadLine();

            //var parsedInput = Int32.Parse(input);

            //if (parsedInput >= 1 && parsedInput <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}


            //Exercise 2

            //Console.WriteLine("Enter a number:");

            //var input2 = Console.ReadLine();

            //var parsedInput2 = Int32.Parse(input2);

            //Console.WriteLine("Enter another number:");

            //var input3 = Console.ReadLine();

            //var parsedInput3 = Int32.Parse(input3);

            //Console.WriteLine(Math.Max(parsedInput2, parsedInput3));

            //if (parsedInput2 > parsedInput3)
            //{
            //    Console.WriteLine("{0} is greater", parsedInput2);
            //}
            //else if (parsedInput3 > parsedInput2)
            //{
            //    Console.WriteLine("{0} is greater", parsedInput3);
            //}
            //else
            //{
            //    Console.WriteLine("The numbers are equal.");
            //}

            //Exercise 3

            //Console.WriteLine("Enter height:");

            //var input2 = Console.ReadLine();

            //var height = Int32.Parse(input2);

            //Console.WriteLine("Enter width:");

            //var input3 = Console.ReadLine();

            //var width = Int32.Parse(input3);

            //if (height > width)
            //{
            //    Console.WriteLine("Picture is portrait.");
            //}
            //else if (width > height)
            //{
            //    Console.WriteLine("Picture is landscape.");
            //}
            //else
            //{
            //    Console.WriteLine("Hang it however you want.");
            //}

            //Exercise 4

            Console.WriteLine("Enter speed limit:");

            var speedLimit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is the speed of the car?");

            var speed = Int32.Parse(Console.ReadLine());

            if (speed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (speed > speedLimit)
            {
                var demeritpoints = (speed - speedLimit) / 5;
                Console.WriteLine("Speed limit exceeded; you have {0} demerit points", demeritpoints);
                if (demeritpoints > 12)
                {
                    Console.WriteLine("License suspended, punk.");
                }
            }
                


        }
    }
}
