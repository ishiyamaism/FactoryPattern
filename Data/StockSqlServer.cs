namespace FactoryPattern.Data;

internal sealed class StockSqlServer : IStock
{
  public int GetStock()
  {
    return 1;
  }

}
