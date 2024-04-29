namespace FactoryPattern.Data;

internal sealed class ProductFake : IProduct
{
  public string GetData()
  {
    return "fake mode";
  }

  public DateTime GetValidDateTime()
  {
    return Convert.ToDateTime("2023/12/31");
  }
}
