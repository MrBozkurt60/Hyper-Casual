using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] Material GroundMaterial;
    [SerializeField] Color[] colors;
    int ColorIndex = 0;
    [SerializeField] float LerpValue , time ;
    float CurrentTime;

    void Start()
    {
        
    }

    void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorCheck();
    }

    void SetColorChangeTime()
    {
        if(CurrentTime <= 0)
        {
            CheckColorIndexValue();
            CurrentTime = time;
        }
        else
        {
            CurrentTime -= Time.deltaTime;
        }
    }

    void CheckColorIndexValue()
    {
        ColorIndex++;

        if(ColorIndex >= colors.Length)
        {
            ColorIndex = 0;
        }
    }

    void SetGroundMaterialSmoothColorCheck()
    {
        GroundMaterial.color = Color.Lerp(GroundMaterial.color, colors[ColorIndex], LerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        GroundMaterial.color = colors[1];
    }
}
