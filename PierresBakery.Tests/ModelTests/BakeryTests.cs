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

    [TestMethod]
    public void BreadCost_ThreeLoaves_Ten()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.BreadCost(3));
    }

    [TestMethod]
    public void BreadCost_FourLoaves_Fifteen()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(15, newBread.BreadCost(4));
    }

    [TestMethod]
    public void BreadCost_SixLoaves_Twenty()
    { 
      Bread newBread = new Bread();
      Assert.AreEqual(20, newBread.BreadCost());   
    }
  }
}