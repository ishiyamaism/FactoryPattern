using FactoryPattern.Exceptions;

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
      throw new InvalidArgumentException(kind);
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
      throw new InvalidArgumentException(kind);
    }
  }
}
