namespace FactoryPattern.Data;

internal sealed class StockSqlServer : IStock
{
  public int GetStock()
  {
    return 20;
  }

  public int GetValidStock()
  {
    return 12;
  }
}
