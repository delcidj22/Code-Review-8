using System.Collections.Generic;

namespace VendorsAndOrders.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, string name, string price)
    {
      Name = name;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}