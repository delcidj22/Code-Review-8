using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorsAndOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorsAndOrders.Tests
{
  [TestClass]
  public class VendorsTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      //Arrange 
      Vendor newVendor = new Vendor("Test Vendor", "Test Description");

      //Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      //Arrange 
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act 
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange 
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Pierre's Bakery";
      string description01 = "Dough and Sprinkles";
      string name02 = "Jon's Bakery";
      string description02 = "Coffee and Chocolate";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act 
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange 
      string name01 = "Pierre's Bakery";
      string description01 = "Dough and Sprinkles";
      string name02 = "Jon's Bakery";
      string description02 = "Coffee and Chocolate";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      //Act 
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
  }
}
