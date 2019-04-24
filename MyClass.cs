using System;
using System.Collections.Generic;

namespace HelloWorld
{
  public class MyClass
  {
    public string ReturnMessage()
    {

      // Variables & Types
      string productName = "TV";
      int productYear = 2012;
      float productPrice = 279.99f;

      Console.WriteLine(productName);
      Console.WriteLine(productYear);
      Console.WriteLine(productPrice);

      // Conditionals
      int guess = 500;
      if (guess == 500)
      {
        Console.WriteLine("Success!");
      }

      // Arrays 
      string[] fruits = { "apple", "banana", "orange" };
      Console.WriteLine(fruits[0]);
      Console.WriteLine(fruits[1]);
      Console.WriteLine(fruits[2]);

      // Lists
      List<int> primeNumbers = new List<int>();

      primeNumbers.Add(2);
      primeNumbers.Add(3);
      primeNumbers.Add(5);
      primeNumbers.Add(7);
      primeNumbers.Add(11);

      // Dictionaries
      Dictionary<string, int> inventory = new Dictionary<string, int>();

      inventory.Add("apple", 3);
      inventory.Add("orange", 5);
      inventory["banana"] = 2;

      Console.WriteLine(inventory["apple"]);
      Console.WriteLine(inventory["orange"]);
      Console.WriteLine(inventory["banana"]);

      // Strings

      // ToString()
      int integer = 1;
      string ourString = "Something to be replaced by an int";
      ourString = integer.ToString();
      Console.WriteLine(ourString);


      // String.Format()
      int x = 1, y = 2;
      int sum = x + y;
      string sumCalculation = String.Format("{2} + {1} = {0}", x, y, sum);
      Console.WriteLine(sumCalculation);


      // Substring()
      string fullString = "full string";
      string partOfString = fullString.Substring(4);
      string shorterPart = fullString.Substring(5, 3);
      Console.WriteLine(partOfString);
      Console.WriteLine(shorterPart);


      // Replace()
      string name = "John Doe";
      string newName = name.Replace("John", "Eric");
      Console.WriteLine(newName);


      // IndexOf()
      string fruit = "apple,orange,banana";
      Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
      Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));


      // Exercice
      string firstName1 = "John";
      string lastName1 = "Doe";
      int age = 27;
      string sentence1 = firstName1 + " " + lastName1 + " is " + age.ToString() + " years old.";
      Console.WriteLine(sentence1);

      // For loops
      for (int n = 0; n < 10; n++)
      {
        string test = "Bora";
        Console.WriteLine(test);
      }

      // While loops
      string test2 = "Bora";
      int m = 0;

      while (m == 0)
      {
        Console.WriteLine(test2);
        m++;
      }

      // Methods
      int Multiply(int a, int b)
      {
        return a / b;
      }
      Console.WriteLine(Multiply(12, 4));

      return "Happy coding !";
    }
  }
}