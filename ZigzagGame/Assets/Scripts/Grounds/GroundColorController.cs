using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors; // renkleri gireceğiz

    private int colorIndex = 0;   // renklerde gezmesini sağlayacağız.
    [SerializeField] private float lerpValue;

    [SerializeField] private float time; // zamanlayıcı oluşturacağız.

    private float currentTime;

    private void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime()
    {
        if(currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        colorIndex++;
        
     if(colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }
    private void SetGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);

    }

    private void OnDestroy()
    {
        groundMaterial.color = colors[1]; 
    }
}
