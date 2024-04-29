using FactoryPattern.Data;
using FactoryPattern.Factory;
using FactoryPattern.Services;

namespace FactoryPattern;

static class Program
{
    public static int Kind { get; set; } = 1;

    // Abstract Factoryパターン
    private static AbstractFactory _factory = AbstractFactory.Create(Kind);
    private static IProduct _product = _factory.CreateProduct();
    private static IStock _stock = _factory.CreateStock();

    //  Factory Methodパターン
    // private static ProductServiceFactory _productService = new ProductServiceFactory();
    // private static IProduct _product = _productService.Create();
    // private static StockServiceFactory _stockService = new StockServiceFactory();
    // private static IStock _stock = _stockService.Create();


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
                    Kind = 0;
                    _factory = AbstractFactory.Create(Kind);
                    _product = _factory.CreateProduct();
                    _stock = _factory.CreateStock();
                    break;
                case ConsoleKey.D1:
                    Console.WriteLine("Press: 1");
                    Kind = 1;
                    _factory = AbstractFactory.Create(Kind);
                    _product = _factory.CreateProduct();
                    _stock = _factory.CreateStock();
                    break;

                default:
                    break;
            }
        }
    }
}
