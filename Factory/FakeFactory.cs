using FactoryPattern.Data;

namespace FactoryPattern.Factory;

internal sealed class FakeFactory : AbstractFactory
{
  public override IProduct CreateProduct()
  {
    return new ProductFake();
  }

  public override IStock CreateStock()
  {
    return new StockFake();

  }
}
