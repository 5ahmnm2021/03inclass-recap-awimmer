using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField Num01;
    public InputField Num02;
    public Text result;
    public Text fehler;

    public void AddNumbersOnClick()
    {
        float num1float = 0;
        float num2float = 0;
        bool num1 = true;
        bool num2 = true;
        string fehlerText = "Zahl eintippen!";

        try
        {
            num1float = float.Parse(Num01.text);
            Num01.image.color = new Color32(255, 255, 255, 255);
            num1 = true;
        }
        catch
        {
            Num01.image.color = new Color32(255, 0, 0, 255);
            Num01.text = fehlerText;
            num1 = false;
        }

        try
        {
            num2float = float.Parse(Num02.text);
            Num02.image.color = new Color32(255, 255, 255, 255);
            num2 = true;
        }
        catch
        {
            Num02.image.color = new Color32(255, 0, 0, 255);
            Num02.text = fehlerText;
            num2 = false;
        }

        if (num1 && num2)
        { 
            result.text = (num1float + num2float).ToString();
            fehler.text = "Super gemacht!";
        }
        else
        {
            fehler.text = "You forgot to type a number!";
        }
    }
}
