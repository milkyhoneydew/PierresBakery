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
      Assert.AreEqual(20, newBread.BreadCost(6));   
    }

    [TestMethod]
    public void BreadCost_SevenLoaves_TwentyFive()
    { 
      Bread newBread = new Bread();
      Assert.AreEqual(25, newBread.BreadCost(7));   
    }

    [TestMethod]
    public void PastryCost_OnePastry_Two()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.PastryCost(1));
    }

    [TestMethod]
    public void PastryCost_TwoPastries_Four()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(4, newPastry.PastryCost(2));
    }

    [TestMethod]
    public void PastryCost_ThreePastries_Six()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(6, newPastry.PastryCost(3));
    }

    [TestMethod]
    public void PastryCost_FourPastries_Six()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(6, newPastry.PastryCost(4));
    }

    [TestMethod]
    public void PastryCost_FivePastries_Eight()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(8, newPastry.PastryCost(5));
    }

    [TestMethod]
    public void PastryCost_SevenPastries_Twelve()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(12, newPastry.PastryCost(7));
    }

    [TestMethod]
    public void PastryCost_EightPastries_Twelve()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(12, newPastry.PastryCost(8));
    }

  }
}