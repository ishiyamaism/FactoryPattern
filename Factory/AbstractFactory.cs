using FactoryPattern.Data;
using FactoryPattern.Exceptions;

namespace FactoryPattern.Factory;

public abstract class AbstractFactory
{
  public abstract IProduct CreateProduct();
  public abstract IStock CreateStock();

  public static AbstractFactory Create(int kind)
  {
    if (kind == 0)
    {
      return new FakeFactory();
    }
    else if (kind == 1)
    {
      return new SqlServerFactory();
    }

    throw new InvalidArgumentException(kind);
  }
}
