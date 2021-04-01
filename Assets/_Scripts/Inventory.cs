using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Items> itemList;

    public Inventory()
    {
        itemList = new List<Items>();

        AddItem(new Items { itemType = Items.ItemType.Gun, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.HealthPotion, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Ammo, amount = 1 });
        Debug.Log(itemList.Count);
    }

    public void AddItem(Items item)
    {
        itemList.Add(item);
    }

    public List<Items> GetItemsList()
    {
        return itemList;
    }
}
