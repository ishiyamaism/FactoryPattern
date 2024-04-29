namespace FactoryPattern.Data;

internal sealed class ProductSqlServer : IProduct
{
  public string GetData()
  {
    return "sql server";
  }

  public DateTime GetValidDateTime()
  {
    return Convert.ToDateTime("2024/12/31");
  }
}
