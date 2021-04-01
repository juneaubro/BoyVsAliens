using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public enum ItemType
    {
        Gun,
        HealthPotion,
        Ammo,
    }

    public ItemType itemType;
    public int amount;
}
