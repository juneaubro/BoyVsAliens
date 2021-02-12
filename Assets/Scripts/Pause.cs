using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    private float originalTimeScale;
    private float originalSpinSpeed;

    private bool pause;
    private void Start()
    {
        pause = false;
        originalTimeScale = Time.timeScale;
        originalSpinSpeed = SpinningPlatform.spinSpeed;
    }

    private void Update()
    {
        PauseGame();
    }

    private void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P) && !pause)
        {
            pauseScreen.SetActive(true);

            Cursor.lockState = CursorLockMode.None;

            SpinningPlatform.spinSpeed = 0f;

            Time.timeScale = 0f;

            pause = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && pause)
        {
            pauseScreen.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;

            SpinningPlatform.spinSpeed = originalSpinSpeed;

            Time.timeScale = originalTimeScale;

            pause = false;
        }
    }
}
