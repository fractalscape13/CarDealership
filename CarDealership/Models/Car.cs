using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Info { get; set; }
    private static List<Car> _instances = new List<Car> { };
    public static List<Car> validCars = new List<Car> { };


    public Car(string makeModel, int price, int miles, string info)
    {
      _instances.Add(this);
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Info = info;
    }

    public static List<Car> GetAll()
    {
        return _instances;
    }
    public static List<Car> GetAllValidCars()
    {
        return validCars;
    }

    public void SetValidCars()
    {
        validCars.Add(this);
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
