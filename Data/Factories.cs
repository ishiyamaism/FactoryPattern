namespace FactoryPattern.Data;

public static class Factories
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

  public static IStock CreateStock(int kind)
  {
    if (kind == 0)
    {
      return new StockFake();
    }
    else if (kind == 1)
    {
      return new StockSqlServer();
    }
    else
    {
      throw new ArgumentException("指定した数字が間違っています");
    }
  }
}
