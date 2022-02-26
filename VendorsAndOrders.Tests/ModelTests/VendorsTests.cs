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


  }
}