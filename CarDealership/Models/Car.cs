using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Info { get; set; }

    public Car(string makeModel, int price, int miles, string info)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Info = info;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }


    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
    public bool MeetCriteria(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }
  }
}
