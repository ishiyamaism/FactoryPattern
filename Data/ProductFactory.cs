namespace FactoryPattern.Data;

public static class ProductFactory
{
  public static IProduct CreateProduct(int kind)
  {
    if (kind == 0)
    {
      return new ProductFake();
    }
    else if (kind == 1)
    {
      return new ProductSqlServer();
    }
    else
    {
      throw new ArgumentException("指定した数字が間違っています");
    }
  }
}
