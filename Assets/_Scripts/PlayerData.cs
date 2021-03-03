using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public Vector3 playerPos;
    public int healthData;

    private void Awake()
    {
    }

    private void Update()
    {
        playerPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 playerPosition = playerPos;
        healthData = PlayerHealth.currentHealth;
    }

    public void SavePlayer()
    {
        SaveSystem.SaveGame(this);
    }

    public void LoadPlayer()
    {
        SaveData data = SaveSystem.LoadData();

        healthData = data.playerHealth;

        Vector3 position;
        position.x = data.playerPosition[0];
        position.y = data.playerPosition[0];
        position.z = data.playerPosition[0];
        transform.position = position;
    }
}