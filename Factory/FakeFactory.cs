using FactoryPattern.Data;

namespace FactoryPattern.Factory;

internal sealed class FakeFactory : AbstractFactory
{
  public override IProduct CreateProduct()
  {
    return new ProductFake();
  }

  public override IStock Createstock()
  {
    return new StockFake();

  }
}
