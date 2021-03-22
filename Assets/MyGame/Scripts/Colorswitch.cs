using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colorswitch : MonoBehaviour
{
    public Image colorField;
    
    public void ChangeColor()
    {
       int randomNumber;

        var colors = new List<Color>()
        {
            new Color32(102, 178, 255, 100),     
            new Color32(255, 153, 204, 100),       
            new Color32(178, 102, 255, 100),      
            new Color32(64, 64, 64, 100)      
        };

        if (Input.GetKeyDown("space"))
        {
            randomNumber = Random.Range(0, colors.Count);
            colorField.color = colors[randomNumber];
        }
    }
    void Update()
    {
        ChangeColor();
    }
}       