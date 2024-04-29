namespace FactoryPattern.Data;

internal sealed class StockFake : IStock
{
  public int GetStock()
  {
    return 2;
  }

  public int GetValidStock()
  {
    return 1;
  }
}
