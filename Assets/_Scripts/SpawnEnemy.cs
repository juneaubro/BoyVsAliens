using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject player;
    private Vector3 spawnPoint;
    private GameObject temp;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        spawnPoint = player.transform.position;
    }
    public void SpawnMaynard()
    {
        temp = Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
    }
}
