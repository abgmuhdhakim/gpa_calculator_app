using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculate : MonoBehaviour
{
    public InputField Credit1;
    public InputField Grade1;
    public InputField Credit2;
    public InputField Grade2;
    public TextMeshProUGUI InputText;
    bool line2 = false;

    public void Calc()
    {
        float cred1 = float.Parse(Credit1.text);
        float gred1 = float.Parse(Grade1.text);
        float cred2 = float.Parse(Credit1.text);
        float gred2 = float.Parse(Grade1.text);

        if (line2 == true)
        {
            InputText.text = (((cred1*gred1)+(cred2*gred2))/(cred1+cred2)).ToString();
        }
        else
        {
            InputText.text = ((cred1*gred1)/cred1).ToString();
        }
    }
    public void line2true()
    {
        InputText.text = null;
        line2 = true;
    }
    public void line2false()
    {
        InputText.text = null;
        line2 = false;
    }
}
