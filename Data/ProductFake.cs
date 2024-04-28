namespace FactoryPattern.Data;

public sealed class ProductFake : IProduct
{
  public string GetData()
  {
    return "fake mode";
  }
}
