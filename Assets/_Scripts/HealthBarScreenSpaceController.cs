using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBarScreenSpaceController : MonoBehaviour
{
    [Header("Health Properties")]
    [Range(0,100)]
    public int currentHealth = 100;
    [Range(1, 100)]
    public int maxHealth = 100;

    Slider healthBarSlider;

    private void Start()
    {
        healthBarSlider = GetComponent<Slider>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        healthBarSlider.value -= damage;
        currentHealth -= damage;

        if(currentHealth < 0)
        {
            healthBarSlider.value = 0;
            currentHealth = 0;
        }
    }

    public void Reset()
    {
        healthBarSlider.value = maxHealth;
        currentHealth = maxHealth;
    }
}

