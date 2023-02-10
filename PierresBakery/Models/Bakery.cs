using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{

  public class Bread
  {
    public int BreadCost (int amount)
    {
      int cost = 0;
      if ((amount > 2) && (amount % 2 == 1)) 
      {
      cost = (amount - 1) * 5;
      }
      else
      {
        cost = amount * 5;
      }
      return cost;
    }
  }
}
