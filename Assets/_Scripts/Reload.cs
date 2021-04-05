using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public void onClickReload()
    {
        int maxAmmo = 30;
        int ammoDifference = maxAmmo - Items.GunAmount;

        if(Items.AmmoAmount <= 30)
        {
            Items.GunAmount = Items.GunAmount + Items.AmmoAmount;
            Items.AmmoAmount = 0;
        }
        else if(Items.GunAmount < maxAmmo) {
        Items.GunAmount = Items.GunAmount + ammoDifference;
        Items.AmmoAmount = Items.AmmoAmount - ammoDifference;
        }
        else if(Items.GunAmount > maxAmmo) {
            Debug.Log("Magazine full!");
        }
    }
}
