using FactoryPattern.Data;

namespace FactoryPattern.Factory;

public abstract class AbstractFactory
{
  public abstract IProduct CreateProduct();
  public abstract IStock Createstock();

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

    throw new ArgumentException("kindがおかしい");
  }
}
