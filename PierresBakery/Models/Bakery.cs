using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{

  public class Bread
  {
    public int BreadCost (int amount)
    {
      int cost = amount * 5;
      return cost;
    }
  }
}
