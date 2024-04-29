using FactoryPattern.Data;
using FactoryPattern.Exceptions;

namespace FactoryPattern.Services;

internal sealed class ProductServiceFactory : ProductService
{
  public override IProduct FactoryMethod(int kind)
  {
    if (kind == 0)
    {
      return new ProductFake();
    }
    else if (kind == 1)
    {
      return new ProductSqlServer();
    }

    throw new InvalidArgumentException(kind);
  }
}
