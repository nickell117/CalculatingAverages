using System;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 10 numbers between 0 and 100");
            Console.Write("First Number: ");
            string one = Console.ReadLine();
            double first = double.Parse(one);

            Console.Write("Second Number: ");
            string two = Console.ReadLine();
            double second = double.Parse(two);

            Console.Write("Third Number: ");
            string three = Console.ReadLine();
            double third = double.Parse(three);

            Console.Write("Fourth Number: ");
            string four = Console.ReadLine();
            double fourth = double.Parse(four);

            Console.Write("Five Number: ");
            string five = Console.ReadLine();
            double fifth = double.Parse(five);

            Console.Write("Sixth Number: ");
            string six = Console.ReadLine();
            double sixth = double.Parse(six);

            Console.Write("Seventh Number: ");
            string seven = Console.ReadLine();
            double seventh = double.Parse(seven);

            Console.Write("Eighth Number: ");
            string eight = Console.ReadLine();
            double eighth = double.Parse(eight);

            Console.Write("Ninth Number: ");
            string nine = Console.ReadLine();
            double ninth = double.Parse(nine);

            Console.Write("Tenth Number: ");
            string ten = Console.ReadLine();
            double tenth = double.Parse(ten);


            double sum = first + second + third + fourth + fifth + sixth + seventh + eighth + ninth + tenth;
            Console.WriteLine("The Sum of the 10 numbers is: " + sum);
            double score = sum / 10;
            Console.WriteLine("The Average is :" + score);

            string grade;
            if (score > 100)
            {
                grade = "ERROR numbers are outside the Scope";
                Console.WriteLine(grade);
            }
            else if (score > 90)
            {
                grade = "A";
                Console.WriteLine("The Grade is :" + grade);
            }
            else if (score > 80)
            {
                grade = "B";
                Console.WriteLine("The Grade is :" + grade);
            }
            else if (score > 70)
            {
                grade = "C";
                Console.WriteLine("The Grade is :" + grade);
            }
            else if (score > 60)
            {
                grade = "D";
                Console.WriteLine("The Grade is :" + grade);
            }
            else if (score > 0)
            {
                grade = "F";
                Console.WriteLine("The Grade is :" + grade);
            }


        }

    }
}

