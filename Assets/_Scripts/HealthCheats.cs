using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCheats : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerHealth.currentHealth = PlayerHealth.maxHealth;
        }
    }
}
