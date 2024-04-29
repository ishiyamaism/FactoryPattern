using FactoryPattern.Data;

namespace FactoryPattern.Services;

public abstract class ProductService
{
  public IProduct Create()
  {
    // productがなんか知らないが、
    // サブクラスが生成するインスタンスに対するロジックを書く

    // ここに共通メソッドを入れられるのがFactory Methodの利点
    var product = FactoryMethod(Program.Kind);
    var validDate = product.GetValidDateTime();
    if (validDate < DateTime.Now)
    {
      throw new Exception("有効期限切れの製品です");
    }
    Console.WriteLine($"有効期限: {validDate}");
    return product;
  }

  /// <summary>
  /// Product生成のためのメソッド
  /// (生成はサブクラスに任せる)
  /// </summary>
  /// <param name="kind"></param>
  /// <returns></returns>
  public abstract IProduct FactoryMethod(int kind);

}
