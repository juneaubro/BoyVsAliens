using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBlockScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.currentHealth = 0;
        }
    }
}
