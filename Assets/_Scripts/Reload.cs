using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public AudioSource gunSounds;
    public AudioClip reloadSound;

    private void Start()
    {
        gunSounds = GetComponent<AudioSource>();
    }
    public void onClickReload()
    {
        int maxAmmo = 30;
        int ammoDifference = maxAmmo - Items.GunAmount;

        if(Items.AmmoAmount <= 30)
        {
            Items.GunAmount = Items.GunAmount + Items.AmmoAmount;
            Items.AmmoAmount = 0;
            gunSounds.PlayOneShot(reloadSound);
        }
        else if(Items.GunAmount < maxAmmo) {
        Items.GunAmount = Items.GunAmount + ammoDifference;
        Items.AmmoAmount = Items.AmmoAmount - ammoDifference;
        gunSounds.PlayOneShot(reloadSound);
        }
        else if(Items.GunAmount > maxAmmo) {
            Debug.Log("Magazine full!");
        }
    }
}
