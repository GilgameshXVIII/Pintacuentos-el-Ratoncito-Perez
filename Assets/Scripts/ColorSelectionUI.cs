using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionUI : MonoBehaviour
{
    public Image colorDisplay; // Asigna la imagen en el Inspector que mostrará el color.

    public void UpdateSelectedColor(Color color)
    {
        if (colorDisplay != null)
        {
            colorDisplay.color = color;
        }
    }
}

