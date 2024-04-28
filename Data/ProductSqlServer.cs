namespace FactoryPattern.Data;

internal sealed class ProductSqlServer : IProduct
{
  public string GetData()
  {
    return "sql server";
  }
}
