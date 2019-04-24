using System;
using System.Collections.Generic;

namespace BasicClasses
{

  // Basic Classes
  class Car
  {
    public int numTires = 4;
    public int year = 2005;
    public bool runs = true;
  }

  class Program
  {
    static void MainTest(string[] args)
    {
      Car car1 = new Car();
      Car car2 = new Car();
      Car car3 = new Car();

      Console.WriteLine(car1.numTires);
      Console.WriteLine(car1.year);
      Console.WriteLine(car1.runs);
    }
  }
}
