using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    Items items;
    private Transform itemSlotContainer;
    private Transform gunSlotTemplate;
    private Transform healthSlotTemplate;
    private Transform ammoSlotTemplate;
    [SerializeField] private Text ammoCount;
    [SerializeField] private Text healthPotionCount;
    [SerializeField] private Text gunCount;

    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        gunSlotTemplate = itemSlotContainer.Find("gunSlotTemplate");
        healthSlotTemplate = itemSlotContainer.Find("healthSlotTemplate");
        ammoSlotTemplate = itemSlotContainer.Find("ammoSlotTemplate");
    }

    public void SetItems(Items items)
    {
        this.items = items;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        healthPotionCount.text = Items.PotionAmount.ToString();
        ammoCount.text = Items.AmmoAmount.ToString();
        gunCount.text = Items.GunAmount.ToString();

        /*int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;
        foreach (Items item in inventory.GetItemsList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }*/
    }
}

