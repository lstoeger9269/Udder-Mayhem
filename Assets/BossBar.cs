using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBar : MonoBehaviour
{
    public Slider bossSlider;

    public void SetSlider(float amount)
    {
        bossSlider.value = amount;
    }

    public void SetSliderMax(float amount)
    {
        bossSlider.maxValue = amount;
        SetSlider(amount);
    }
}
