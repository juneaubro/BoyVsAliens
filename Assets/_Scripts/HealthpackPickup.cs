using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthpackPickup : MonoBehaviour
{
    public GameObject healthPack;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthPack.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
