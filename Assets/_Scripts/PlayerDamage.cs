using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BadBlack"))
        {
            PlayerHealth.currentHealth -= 15;
            Debug.Log("dmh");
        }
    }

}
