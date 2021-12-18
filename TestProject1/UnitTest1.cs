using System;
using NUnit.Framework;
using Project_Catalog.Classes;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestPriceAtWeek()
    {
        MyCatalog testCatalog = new MyCatalog(new MyFriday());
        decimal actualPrice = 1500;
        decimal realPrice = testCatalog.GetProductList()[0].Price;
        Assert.AreEqual(actualPrice, realPrice);
    }
    
    [Test]
    public void TestPriceAtWeekEnd()
    {
        MyCatalog testCatalog = new MyCatalog(new MySunday());
        decimal actualPrice = 1500*1.5m;
        decimal realPrice = testCatalog.GetProductList()[0].Price;
        Assert.AreEqual(actualPrice, realPrice);
    }
    
}