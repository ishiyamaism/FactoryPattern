using FactoryPattern.Data;
using FactoryPattern.Exceptions;

namespace FactoryPattern.Services;

internal sealed class StockServiceFactory : StockService
{
  public override IStock GenerateStock(int kind)
  {
    if (kind == 0)
    {
      return new StockFake();
    }
    else if (kind == 1)
    {
      return new StockSqlServer();
    }

    throw new InvalidArgumentException(kind);
  }


}
