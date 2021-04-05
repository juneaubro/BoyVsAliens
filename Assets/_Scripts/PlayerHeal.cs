using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    public void onClickHeal()
    {
        if (Items.PotionAmount > 0)
        {
            PlayerHealth.currentHealth = 100;
            Items.PotionAmount--;
        }
        else
            Debug.Log("Health potion empty!");
    }
}
