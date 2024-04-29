using FactoryPattern.Data;

namespace FactoryPattern.Services;

public abstract class StockService
{
  public IStock Create()
  {
    // productがなんか知らないが、
    // サブクラスが生成するインスタンスに対するロジックを書く

    // ここに共通メソッドを入れられるのがFactory Methodの利点
    var stock = GenerateStock(Program.Kind);
    var validStock = stock.GetValidStock();
    if (validStock < 5)
    {
      throw new Exception("在庫切れ間近の製品です。至急入荷手配をお願いします。");
    }
    Console.WriteLine($"有効在庫: {validStock}");
    return stock;
  }

  /// <summary>
  /// Stock生成のためのメソッド
  /// (生成はサブクラスに任せる)
  /// </summary>
  /// <param name="kind"></param>
  /// <returns></returns>
  public abstract IStock GenerateStock(int kind);
}
