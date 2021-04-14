using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaynardHealth : MonoBehaviour
{
    [Header("Health Properties")]
    [Range(0, 100)]
    public static int currentHealth = 100;
    [Range(1, 100)]
    public static int maxHealth = 100;

    Slider healthBarSlider;

    private void Start()
    {
        healthBarSlider = GetComponent<Slider>();
        currentHealth = maxHealth;
    }

    private void Update()
    {
        healthBarSlider.value = currentHealth;
    }

    public void Reset()
    {
        healthBarSlider.value = maxHealth;
        currentHealth = maxHealth;
    }
}
