using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLogic : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Awake()
    {
        slider.value = Difficulty.Value;
    }

    public void ChangeDifficulty(float value)
    {
        Difficulty.Value = (int) value;
        Debug.Log("Current value: " + Difficulty.Value);
    }
}
