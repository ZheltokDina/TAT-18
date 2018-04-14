using System;

namespace AutoShopEvent
{
  class Program
  {
    static void Main(string[] args)
    {
      AutoShop shop = new AutoShop(new Random().Next(30));
      shop.BMWLover += c_BMWLover;
      shop.AudiLover += c_AudiLover;

      Console.WriteLine("press 'a', if you want added BMW car " +
        "\nor  press 'b', if you want added Audi car");
      while (Console.ReadKey(true).KeyChar == 'a')
      {
        Console.WriteLine("adding one BMW car");
        shop.AddedBMWCars(1);
      }
      while (Console.ReadKey(true).KeyChar == 'b')
      {
        Console.WriteLine("adding one Audi car");
        shop.AddedAudiCars(1);
      }
    }
    static void c_BMWLover(object sender, AutoShopEventArgs e)
    {
      Console.WriteLine("{0} - {1} cars.", e.Mark, e.NumberOfCarsThisMark);
    }
    static void c_AudiLover(object sender, AutoShopEventArgs e)
    {
      Console.WriteLine("{0} - {1} cars.", e.Mark, e.NumberOfCarsThisMark);
    }
  }
  class AutoShop
  {
    private int numberOfCars;
    private int totalOfBMW;
    private int totalOfAudi;
    public AutoShop(int numberOfCars)
    {
      this.numberOfCars = numberOfCars;
    }

    public void AddedBMWCars(int numberOfBMWCar)
    {
      AutoShopEventArgs args = new AutoShopEventArgs();
      totalOfBMW += numberOfBMWCar;
      if (totalOfBMW > 1)
      {
        args.Mark = "BMW";
        args.NumberOfCarsThisMark = totalOfBMW;
        OnBMWReached(args);
      }
    }
    public void AddedAudiCars(int numberOfAudiCar)
    {
      AutoShopEventArgs args = new AutoShopEventArgs();
      totalOfAudi += numberOfAudiCar;
      if (totalOfAudi > 5)
      {
        args.Mark = "Audi";
        args.NumberOfCarsThisMark = totalOfAudi;
        OnAudiReached(args);
      }
    }
    protected virtual void OnBMWReached(AutoShopEventArgs e)
    {
      EventHandler<AutoShopEventArgs> handler = BMWLover;
      if (handler != null)
      {
        handler(this, e);
      }
    }
    protected virtual void OnAudiReached(AutoShopEventArgs e)
    {
      EventHandler<AutoShopEventArgs> handler = AudiLover;
      if (handler != null)
      {
        handler(this, e);
      }
    }
    public event EventHandler<AutoShopEventArgs> BMWLover;
    public event EventHandler<AutoShopEventArgs> AudiLover;
  }
  public class AutoShopEventArgs : EventArgs
  {
    public string Mark { get; set; }
    public int NumberOfCarsThisMark { get; set; }
  }
}
