using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public InputField dashInput;
    public Toggle invertToggle;
    public Text changeText;

    bool change = false;

    private void Awake()
    {
        dashInput.text = PlayerPrefs.GetString("DashInputKey","LeftShift");

        if(PlayerPrefs.GetInt("Invert", 1) == 1)
        {
            invertToggle.isOn = false;
        }
        else
        {
            invertToggle.isOn = true;
        }
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("quitting");
        Application.Quit();
    }

    public void SaveInputs()
    {
        PlayerPrefs.SetString("DashInputKey", dashInput.text);

        if (invertToggle.isOn) {
            PlayerPrefs.SetInt("Invert", -1);
        }
        else
        {
            PlayerPrefs.SetInt("Invert", 1);
        }

        PlayerPrefs.Save();
    }
}
