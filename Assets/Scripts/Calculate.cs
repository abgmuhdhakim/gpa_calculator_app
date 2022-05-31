using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculate : MonoBehaviour
{
    public InputField Credit;
    public InputField Grade;

    public TextMeshProUGUI InputText;

    public void Calc()
    {
        float cred = float.Parse(Credit.text);
        float gred = float.Parse(Grade.text);

        InputText.text = (cred + gred).ToString();
    }
    /*public float Calc()
    {
        if (x == A || x == A+)
        {
            return 4.00;
        }
        else if (x == A-)
        {
            return 3.75;
        }
        else if (x == B+)
        {
            return 3.50;
        }
        else if (x == B)
        {
            return 3.25;
        }
        else if (x == B-)
        {
            return 3.00;
        }
        else if (x == C+)
        {
            return 2.75;
        }
        else if (x == C)
        {
            return 2.50;
        }
        else if (x == C-)
        {
            return 2.25;
        }
        else if (x == D+)
        {
            return 2.00;
        }
        else if (x == D)
        {
            return 1.00;
        }
        else
        {
            return 0.00;
        }
    }*/
}
