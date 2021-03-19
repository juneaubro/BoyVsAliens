using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject player;
    private Transform spawn;

    private void Start()
    {
        player = GameObject.Find("Player");
        spawn = GameObject.Find("Spawn").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.currentHealth = 0;
        }
    }
}
