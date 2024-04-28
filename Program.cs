using FactoryPattern.Data;

namespace FactoryPattern;

class Program
{
    private static int Kind { get; } = 0;
    private static IProduct _product = new ProductFake();
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to get data, and the other Keys for Input Trigger. Esc to exit.");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);  // trueでキーのエコーをオフにする
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("bye.");
                break;
            }
            // Escキーでループを抜けてプログラムを終了

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    if (Kind == 0)
                    {
                        _product = new ProductFake();
                    }
                    else if (Kind == 1)
                    {
                        _product = new ProductSqlServer();
                    }
                    else
                    {
                        throw new ArgumentException("指定した数字が間違っています");
                    }
                    Console.WriteLine(_product.GetData());

                    break;
                case ConsoleKey.A:
                    Console.WriteLine("Press: A");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Press: →");
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Press: 0");
                    break;
                case ConsoleKey.D1:
                    Console.WriteLine("Press: 1");
                    break;

                default:
                    break;
            }
        }
    }
}
