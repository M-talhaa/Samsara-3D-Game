using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int newHealth)
    {
        slider.maxValue = newHealth;
    }

    public void SetHealth(int newHealth)
    {
        slider.value = newHealth;
    }
    public void SubtractHealth(int damage)
    {
        slider.value -= damage;
    }
    public void AddHealth(int healing)
    {
        slider.value -= healing;
    }
}
