using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunPickup : MonoBehaviour
{
    public GameObject invGun;
    public GameObject invAmmo;
    public GameObject playerGun;
    public Text itemPickupQuest;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            invGun.SetActive(true);
            invAmmo.SetActive(true);
            playerGun.SetActive(true);
            Destroy(this.gameObject);
            itemPickupQuest.color = UnityEngine.Color.green;
        }
    }
}
