namespace FactoryPattern.Data;

internal sealed class StockSqlServer : IStock
{
  public int GetStock()
  {
    return 11;
  }

  public int GetValidStock()
  {
    return 10;
  }
}
