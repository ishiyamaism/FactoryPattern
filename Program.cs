using FactoryPattern.Data;
using FactoryPattern.Factory;

namespace FactoryPattern;

class Program
{
    private static int _kind = 1;

    private static AbstractFactory _factory = AbstractFactory.Create(_kind);
    private static IProduct _product = _factory.CreateProduct();
    private static IStock _stock = _factory.Createstock();
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

                    Console.WriteLine(_product.GetData());
                    Console.WriteLine(_stock.GetStock());

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
