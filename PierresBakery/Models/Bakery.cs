using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{

  public class Bread
  {
    public int Cost { get; set; }

    public int BreadCost(int amount, int cost)
    {
      Cost = cost;

      // int cost = 0;
      if (amount <= 2) 
      {
      Cost = amount * 5;
      }
      else
      { 
        int freeLoaves = amount / 3;
        int extraLoaves = amount - (freeLoaves * 3);
        Cost = (freeLoaves * 10) + (extraLoaves * 5);
      }
      return Cost;
    }

    public void SetCost(int newCost)
    {
      Cost = newCost;
    }

    public int GetCost()
    {
      return Cost;
    }
  }

  public class Pastry
  {
    public int PastryCost(int amount)
    {
      int cost = 0;
      if (amount <= 3) 
      {
      cost = amount * 2;
      }
      else
      { 
        int freePastries = amount / 4;
        int extraPastries = amount - (freePastries * 4);
        cost = (freePastries * 6) + (extraPastries * 2);
      }
      return cost;
    }
  }
}
