using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {

  public class Program
  {

    static void Main()
    {
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("How many loaves of bread would you like today? If you buy 2, the 3rd is free!");
      string firstAnswer = Console.ReadLine();
      int breadAmount = int.Parse(firstAnswer);
      Bread newBread = new Bread();
      int breadTotal = newBread.BreadCost(breadAmount);
      newBread.SetCost(breadTotal);
      
      Console.WriteLine("The total cost of your bread is " + breadTotal + " dollars.");
      Console.WriteLine("Would you like to add any pastries to your order? ['Y' for yes, 'Enter' for no]");
      string secondAnswer = Console.ReadLine();
      if (secondAnswer == "Y" || secondAnswer == "y")
      {
      Console.WriteLine("How many pastries would you like today? If you buy 3, the 4th is free!");
      string thirdAnswer = Console.ReadLine();
      int pastryAmount = int.Parse(thirdAnswer);
      Pastry newPastry = new Pastry();
      int pastryTotal = newPastry.PastryCost(pastryAmount);
      int orderTotal = pastryTotal + newBread.GetCost();

      Console.WriteLine("The total cost of your pastries is " + pastryTotal + " dollars.");
      Console.WriteLine("The total cost of your order is " + orderTotal);
      }
        else 
        {
          Console.WriteLine("Thanks for coming in! Please check out at the register.");
            Main();
        }
    }

  }
} 
