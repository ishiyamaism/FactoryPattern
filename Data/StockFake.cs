namespace FactoryPattern.Data;

internal sealed class StockFake : IStock
{
  public int GetStock()
  {
    return 0;
  }

  public int GetValidStock()
  {
    return 0;
  }
}
