using System;

namespace myapp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            
            int c = a + b;
            int d = a + b * c;
            Console.WriteLine(d);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits()
        {
            
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"quotient: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void TestDoubles()
        {
        double a = 19;
        double b = 23;
        double c = 8;
        double d = (a + b) / c;
        Console.WriteLine(d);

        double max = double.MaxValue;
        double min =double.MinValue;
        Console.WriteLine($"The range of double is {min} to {max}");

        double third = 1.0 / 3.0;
        Console.WriteLine(third);
        }

        static void TestDecimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of decimal types is {min} to {max}");
            
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

        }

        static void Challenge()
        {
            double circulo = 2.50;
            double result = (circulo * circulo) * Math.PI;
            double anotherResut = Math.Pow(circulo, 2) * Math.PI;
            Console.WriteLine(result);
            Console.WriteLine(anotherResut);
        } 

        static void LearIf ()
        {
            int a = 5;
            int b = 6;
            int c = 4;
            if((a + b + c > 10) || (a == b)) 
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

        }

        static void While ()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        static void For () 
        {
            for (int index = 5; index < 16; index ++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        static void Matriz ()
        {
            for(int row = 1; row < 11; row++)
            {
            Console.WriteLine(row);
            }

            for(char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

           
            for (char column = 'a'; column < 'k'; column++)
            {
                for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
            }
        }

        static void Main(string[] args)
        {
            // WorkingWithIntegers();

            // OrderPrecedence();

            // TestLimits();

            // TestDoubles();

            // TestDecimal();

            // Challenge();

            // LearIf();
            
            // While ();
            
            // For (); 

            Matriz ();


        }
    }
}
