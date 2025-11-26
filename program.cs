using System;
using System.Numerics;
using System.Text;

namespace lab_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            Console.OutputEncoding = utf8;
            // Спочатку testAPlusBSquare для всіх
            TestAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            TestAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));

            // Потім testSquaresDifference для всіх
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));

            // Тест ділення на нуль
            testSquaresDifference(new MyFrac(1, 2), new MyFrac(-1, 2)); // a + b = 0

            Console.ReadKey();
        }

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== testSquaresDifference ===");

            // Обчислюємо a - b
            T difference = a.Subtract(b);
            Console.WriteLine($"a - b = {difference}");

            // Обчислюємо a² - b²
            T aSquared = a.Multiply(a);
            T bSquared = b.Multiply(b);
            T squaresDifference = aSquared.Subtract(bSquared);
            Console.WriteLine($"a² - b² = {squaresDifference}");

            // Обчислюємо a + b
            T sum = a.Add(b);
            Console.WriteLine($"a + b = {sum}");

            // Перевіряємо ділення на нуль
            try
            {
                // Обчислюємо (a² - b²) / (a + b)
                T result = squaresDifference.Divide(sum);
                Console.WriteLine($"(a² - b²) / (a + b) = {result}");

                // Перевіряємо чи результати збігаються
              
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ділення на нуль");
            }

            Console.WriteLine();
        }
        static void TestAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b); // ab
            curr = curr.Add(curr); // ab + ab = 2ab


            // I'm not sure how to create constant factor "2" in more elegant way,
            // without knowing how IMyNumber is implemented
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }
    }
}