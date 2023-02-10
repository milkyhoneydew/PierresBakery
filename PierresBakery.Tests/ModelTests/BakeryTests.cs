using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_OneLoaf_Five()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.BreadCost(1));
    }

    [TestMethod]
    public void BreadCost_TwoLoaves_Ten()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.BreadCost(2));
    }
  }
}