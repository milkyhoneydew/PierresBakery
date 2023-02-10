using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    public void BreadCost_OneLoaf_Two()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.BreadCost());
    }
  }
}