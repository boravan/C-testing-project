using System;
using System.Collections.Generic;

namespace ClassProperties
{

  // Class Properties
  class Vehicle
  {
    public string Type;
    public int Numtires;
    public int Year;
    public bool Runs;

    public Vehicle(string type, int numtires, int year, bool runs)
    {
      Type = type;
      Numtires = numtires;
      Year = year;
      Runs = runs;
    }
  }

  class Program
  {
    static void MainTest(string[] args)
    {
      Vehicle car = new Vehicle("car", 4, 2005, true);
      Vehicle oldcar = new Vehicle("car", 4, 1980, false);
      Vehicle bike = new Vehicle("bike", 2, 2017, true);

      Console.WriteLine("A car : Type = {0}, Numtires = {1}, Year = {2}, Runs = {3}", car.Type, car.Numtires, car.Year, car.Runs);
      Console.WriteLine("An oldcar : Type = {0}, Numtires = {1}, Year = {2}, Runs = {3}", oldcar.Type, oldcar.Numtires, oldcar.Year, oldcar.Runs);
      Console.WriteLine("A bike : Type = {0}, Numtires = {1}, Year = {2}, Runs = {3}", bike.Type, bike.Numtires, bike.Year, bike.Runs);

    }
  }
}
