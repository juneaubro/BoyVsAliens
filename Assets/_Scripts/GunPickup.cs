using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public GameObject invGun;
    public GameObject invAmmo;
    public GameObject playerGun;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            invGun.SetActive(true);
            invAmmo.SetActive(true);
            playerGun.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
