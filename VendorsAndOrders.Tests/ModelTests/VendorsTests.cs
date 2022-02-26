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
      Vendor newVendor = new Vendor("Test Vendor");

      //Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      //Arrange 
      string name = "Vendor Name";
      Vendor newVendor = new Vendor(name);

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
      Vendor newVendor = new Vendor(name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
