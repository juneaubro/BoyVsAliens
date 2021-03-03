using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBlockDoT : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // going to do all things that have health but we will use player for now
        {
            PlayerHealth.currentHealth -= 1;
            Debug.Log("burn");
        }
    }
}
