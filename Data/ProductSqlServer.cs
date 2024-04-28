namespace FactoryPattern.Data;

public sealed class ProductSqlServer : IProduct
{
  public string GetData()
  {
    return "sql server";
  }
}
