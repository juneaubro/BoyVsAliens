using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform gunSlotTemplate;
    private Transform healthSlotTemplate;
    private Transform ammoSlotTemplate;
    [SerializeField] private Text ammoCount;
    [SerializeField] private Text healthPotionCount;

    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        gunSlotTemplate = itemSlotContainer.Find("gunSlotTemplate");
        healthSlotTemplate = itemSlotContainer.Find("healthSlotTemplate");
        ammoSlotTemplate = itemSlotContainer.Find("ammoSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        for (int i = 0; i < inventory.GetItemsList().Count; i++)
        {
            Debug.Log("good boob");
            healthPotionCount.text = inventory.GetItemsList()[i].amount.ToString();
            ammoCount.text = inventory.GetItemsList()[i].amount.ToString();
        }

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

