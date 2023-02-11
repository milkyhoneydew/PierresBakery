using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{

  public class Bread
  {
    public int BreadCost (int amount)
    {
      int cost = 0;
      if (amount <= 2) 
      {
      cost = amount * 5;
      }
      else
      { 
        int freeLoaves = amount / 3;
        int extraLoaves = amount - (freeLoaves * 3);
        cost = (freeLoaves * 10) + (extraLoaves * 5);
      }
      return cost;
    }
  }

  public class Pastry
  {
    public int PastryCost (int amount)
    {
      int cost = 0;
      if (amount <= 2) 
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
