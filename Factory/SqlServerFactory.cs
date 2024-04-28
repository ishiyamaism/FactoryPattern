using FactoryPattern.Data;

namespace FactoryPattern.Factory;

internal sealed class SqlServerFactory : AbstractFactory
{
  public override IProduct CreateProduct()
  {
    return new ProductSqlServer();
  }

  public override IStock Createstock()
  {
    return new StockSqlServer();

  }
}
