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
      Order newOrder = new Order("Test Name", "Test Description");
      //Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescripton_ReturnsDescription_String()
    {
      //Arrange 
      string name = "Coffee";
      string description = "Coffee";
      Order newOrder = new Order(name, description);

      //Act
      string instanceName = newOrder.Name;
      string instanceDescription = newOrder.Description;
    

      //Assert
      Assert.AreEqual(name, instanceName);
      Assert.AreEqual(description, instanceDescription);
    }
  }
}