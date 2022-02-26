using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorsAndOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorsAndOrders.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstancesOfOrder_Order()
    {
      //Arrange
      Order newOrder = new Order("Test Name", "Test Description", "Test Price");
      //Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}