﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    

    public void SetMinProgress(int souls)
    {
        slider.minValue = souls;
        slider.value = souls;
    }

    public void SetProgress(int souls)
    {
        slider.value = souls;
    }
}