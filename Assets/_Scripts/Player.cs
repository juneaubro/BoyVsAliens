using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Items items;
    public GameObject pauseScreen;
    private float originalTimeScale;
    private float originalSpinSpeed;
    private float originalDampen;
    private CharacterController cc;
    private PlayerData data;

    int health = PlayerHealth.currentHealth;

    [SerializeField] private UI_Inventory uiInventory;
    private void Awake()
    {
    }
    private void Start()
    {
        cc = GetComponent<CharacterController>();
        originalTimeScale = Time.timeScale;
        originalSpinSpeed = SpinningPlatform.SpinSpeed;
        originalDampen = MovingPlatform.dampen;
        if(data == null)
        {
            SavePlayer();
        }
    }

    private void Update()
    {
        if (PlayerHealth.currentHealth <= 0)
        {
            LoadPlayer();
        }

        items = new Items();
        uiInventory.SetItems(items);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        pauseScreen.SetActive(false);

        SpinningPlatform.SpinSpeed = originalSpinSpeed;

        MovingPlatform.dampen = originalDampen;

        Time.timeScale = 1;

        Pause.pause = false;

        data = SaveSystem.LoadPlayer();

        PlayerHealth.currentHealth = data.health;
        Vector3 position = new Vector3(data.position[0], data.position[1], data.position[2]);
        cc.enabled = false;
        transform.position = position;
        cc.enabled = true;
    }
}
