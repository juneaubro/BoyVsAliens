using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBlockDoT : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // going to do all things that have health but we will use player for now
        {
            PlayerHealth.currentHealth -= 1;
        }
    }
}
