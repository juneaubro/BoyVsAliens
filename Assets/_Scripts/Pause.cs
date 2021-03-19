using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    private float originalTimeScale;
    private float originalSpinSpeed;
    private float originalDampen;

    public static bool pause;
    private void Start()
    {
        pause = false;
        originalTimeScale = Time.timeScale;
        originalSpinSpeed = SpinningPlatform.SpinSpeed;
        originalDampen = MovingPlatform.dampen;
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P) && !pause)
        {
            pauseScreen.SetActive(true);

            SpinningPlatform.SpinSpeed = 0f;

            MovingPlatform.dampen = 0f;

            Time.timeScale = 0f;

            pause = true;
        }
    }

    public void UnPauseGame()
    {
        pauseScreen.SetActive(false);

        SpinningPlatform.SpinSpeed = originalSpinSpeed;

        MovingPlatform.dampen = originalDampen;

        Time.timeScale = 1;

        pause = false;
    }
}
