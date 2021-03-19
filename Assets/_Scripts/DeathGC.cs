using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGC : MonoBehaviour
{
    private GameObject player;
    private GameObject spawn;

    private void Start()
    {
        player = GameObject.Find("Player");
        spawn = GameObject.Find("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.currentHealth <= 0)
        {
            //player.GetComponent<CharacterController>().enabled = false;
            //player.transform.position = spawn.transform.position;
            //player.GetComponent<CharacterController>().enabled = true;

            //Player.LoadPlayer();

            //PlayerHealth.currentHealth = 100;
        }
    }
}
