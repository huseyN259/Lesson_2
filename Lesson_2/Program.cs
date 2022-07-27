using System;

namespace Lesson2
{
    class Program
    {
        static float Add(float x, float y) => x + y;
        static float Diff(float x, float y) => x - y;
        static float Mult(float x, float y) => x * y;
        static float Div(float x, float y) => (y == 0) ? 0 : x / y;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            float x, y;
            char op;

            while (true)
            {
                Console.Write("Enter the first number : ");
                float.TryParse(Console.ReadLine(), out x);
                Console.Clear();

                do
                {
                    Console.Write("Enter operator ( +, -, *, / ) : ");
                    char.TryParse(Console.ReadLine(), out op);
                    Console.Clear();
                } while (op != '+' && op != '-' && op != '*' && op != '/');

                Console.Write("Enter the second number : ");
                float.TryParse(Console.ReadLine(), out y);

                Console.Write($"{x} {op} {y} = ");

                switch (op)
                {
                    case '+':
                        Console.WriteLine(Add(x, y));
                        break;
                    case '-':
                        Console.WriteLine(Diff(x, y));
                        break;
                    case '*':
                        Console.WriteLine(Mult(x, y));
                        break;
                    case '/':
                        Console.WriteLine(Div(x, y));
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                string @forAgain;

                Console.ForegroundColor = ConsoleColor.Green;
                do
                {
                    Console.WriteLine("Do you want to continue ? Yes / No");
                    @forAgain = Console.ReadLine();
                    @forAgain = @forAgain?.ToLower();
                    Console.Clear();
                } while (@forAgain != "no" && @forAgain != "yes");

                if (@forAgain == "no")
                    break;
            }
        }
    }
}