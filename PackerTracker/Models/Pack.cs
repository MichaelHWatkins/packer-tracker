using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class Pack
    {
      public string ItemName {get; set; }
      public int Price { get; set; }
      public int Weight {get;}
      public int Id { get; }
      private static List<Pack> _packList = new List<Pack> {};

      public Pack(string itemName, int price, int weight)
      {
        ItemName = itemName;
        Price = price;
        Weight = weight;
        _packList.Add(this);
        Id = _packList.Count;
      }

      public static List<Pack> GetAll()
      {
        return _packList;
      }

      public static void ClearAll()
      {
        _packList.Clear();
      }

      public static Pack Find(int searchId)
      {
        return _packList[searchId-1];
      }
    }
}