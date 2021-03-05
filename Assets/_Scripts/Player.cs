using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject pauseScreen;
    private float originalTimeScale;
    private float originalSpinSpeed;
    private float originalDampen;
    private CharacterController cc;

    int health = PlayerHealth.currentHealth;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        originalTimeScale = Time.timeScale;
        originalSpinSpeed = SpinningPlatform.SpinSpeed;
        originalDampen = MovingPlatform.dampen;
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        pauseScreen.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;

        SpinningPlatform.SpinSpeed = originalSpinSpeed;

        MovingPlatform.dampen = originalDampen;

        Time.timeScale = 1;

        Pause.pause = false;

        PlayerData data = SaveSystem.LoadPlayer();

        PlayerHealth.currentHealth = data.health;
        Debug.Log(data.health);
        Vector3 position = new Vector3(data.position[0], data.position[1], data.position[2]);
        cc.enabled = false;
        transform.position = position;
        cc.enabled = true;
        Debug.Log(position);
    }
}
