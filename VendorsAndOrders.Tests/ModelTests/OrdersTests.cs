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

    [TestMethod]
    public void GetDescripton_ReturnsDescription_String()
    {
      //Arrange 
      string name = "Coffee";
      string description = "Coffee";
      string price = "20.00";
      Order newOrder = new Order(name, description, price);

      //Act
      string instanceName = newOrder.Name;
      string instanceDescription = newOrder.Description;
      string instancePrice = newOrder.Price;

      //Assert
      Assert.AreEqual(name, instanceName);
      Assert.AreEqual(description, instanceDescription);
      Assert.AreEqual(price, instancePrice);
    }
  }
}