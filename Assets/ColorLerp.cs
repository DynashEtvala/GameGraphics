using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorLerp : MonoBehaviour
{
    public Color Color1;
    public Color Color2;

    float lerpVal;
    Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnValueChanged(float newValue)
    {
        lerpVal = newValue;
        image.color = Color.Lerp(Color1, Color2, lerpVal);
    }
}
