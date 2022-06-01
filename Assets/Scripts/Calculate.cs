/*
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
    public InputField Credit3;
    public InputField Grade3;
    public InputField Credit4;
    public InputField Grade4;
    public InputField Credit5;
    public InputField Grade5;
    public InputField Credit6;
    public InputField Grade6;
    public InputField Credit7;
    public InputField Grade7;
    public InputField Credit8;
    public InputField Grade8;
    public InputField Credit9;
    public InputField Grade9;
    public InputField Credit10;
    public InputField Grade10;
    public TextMeshProUGUI OutputText;

    bool linet = true;
    bool line6t = false;
    bool line7t = false;
    bool line8t = false;
    bool line9t = false;
    bool line10t = false;

    public void Calc()
    {
        float gred1 = float.Parse(Grade1.text);
        float gred2 = float.Parse(Grade2.text);
        float gred3 = float.Parse(Grade3.text);
        float gred4 = float.Parse(Grade4.text);
        float gred5 = float.Parse(Grade5.text);
        float gred6 = float.Parse(Grade6.text);
        float gred7 = float.Parse(Grade7.text);
        float gred8 = float.Parse(Grade8.text);
        float gred9 = float.Parse(Grade9.text);
        float gred10 = float.Parse(Grade10.text);
        float cred1 = float.Parse(Credit1.text);
        float cred2 = float.Parse(Credit2.text);
        float cred3 = float.Parse(Credit3.text);
        float cred4 = float.Parse(Credit4.text);
        float cred5 = float.Parse(Credit5.text);
        float cred6 = float.Parse(Credit6.text);
        float cred7 = float.Parse(Credit7.text);
        float cred8 = float.Parse(Credit8.text);
        float cred9 = float.Parse(Credit9.text);
        float cred10 = float.Parse(Credit10.text);

        if (linet == true)
        {
            OutputText.text = (((cred1*gred1)+(cred2*gred2))/(cred1+cred2)).ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5)) 
                / totalCred(cred1, cred2, cred3, cred4, cred5)
            ).ToString();
        }
        else if(line6t == true)
        {
            OutputText.text = ("2").ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5) + line6(cred6,gred6))
            ).ToString();
        }
        else if (line7t == true)
        {
            OutputText.text = ("3").ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5) + line6(cred6,gred6) + line7(cred7,gred7)) / 
                totalCred7(cred1, cred2, cred3, cred4, cred5, cred6, cred7)
            ).ToString();
        }
        else if (line8t == true)
        {
            OutputText.text = ("4").ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5) + line6(cred6,gred6) + line7(cred7,gred7) 
                + line8(cred8,gred8)) / 
                totalCred8(cred1, cred2, cred3, cred4, cred5, cred6, cred7, cred8)
            ).ToString();
        }
        else if (line9t == true)
        {
            OutputText.text = ("5").ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5) + line6(cred6,gred6) + line7(cred7,gred7) 
                + line8(cred8,gred8) + line9(cred9,gred9)) 
                / totalCred9(cred1, cred2, cred3, cred4, cred5, cred6, cred7, cred8, cred9)
            ).ToString();
        }
        else if (line10t == true)
        {
            OutputText.text = ("6").ToString();
            /*(
                (line1(cred1,gred1) + line2(cred2,gred2) + line3(cred3,gred3) 
                + line4(cred4,gred4) + line5(cred5,gred5) + line6(cred6,gred6) + line7(cred7,gred7) 
                + line8(cred8,gred8) + line9(cred9,gred9) + line10(cred10,gred10)) / 
                totalCred10(cred1, cred2, cred3, cred4, cred5, cred6, cred7, cred8, cred9, cred10)
            ).ToString();
        }
    }*/
/*
    float line1(float cred1, float gred1)
    {
        return cred1 * gred1;
    }

    float line2(float cred2, float gred2)
    {
        return cred2 * gred2;
    }

    float line3(float cred3, float gred3)
    {
        return cred3 * gred3;
    }

    float line4(float cred4, float gred4)
    {
        return cred4 * gred4;
    }

    float line5(float cred5, float gred5)
    {
        return cred5 * gred5;
    }

    float line6(float cred6, float gred6)
    {
        return cred6 * gred6;
    }

    float line7(float cred7, float gred7)
    {
        return cred7 * gred7;
    }

    float line8(float cred8, float gred8)
    {
        return cred8 * gred8;
    }

    float line9(float cred9, float gred9)
    {
        return cred9 * gred9;
    }

    float line10(float cred10, float gred10)
    {
        return cred10 * gred10;
    }

    float totalCred(float cred1, float cred2, float cred3, float cred4, float cred5)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5;
    }

    float totalCred6(float cred1, float cred2, float cred3, float cred4, float cred5, float cred6)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5 + cred6;
    }

    float totalCred7(float cred1, float cred2, float cred3, float cred4, float cred5, float cred6, float cred7)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7;
    }

    float totalCred8(float cred1, float cred2, float cred3, float cred4, float cred5, float cred6, float cred7, float cred8)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8;
    }

    float totalCred9(float cred1, float cred2, float cred3, float cred4, float cred5, float cred6, float cred7, float cred8, float cred9)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8 + cred9;
    }

    float totalCred10(float cred1, float cred2, float cred3, float cred4, float cred5, float cred6, float cred7, float cred8, float cred9, float cred10)
    {
        return cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8 + cred9 + cred10;
    }

    public void linetr()
    {
        linet = true;
        line6t = false;
        line7t = false;
        line8t = false;
        line9t = false;
        line10t = false;
    }

    public void line6tr()
    {
        linet = false;
        line6t = true;
        line7t = false;
        line8t = false;
        line9t = false;
        line10t = false;
    }

    public void line7tr()
    {
        linet = false;
        line6t = false;
        line7t = true;
        line8t = false;
        line9t = false;
        line10t = false;
    }

    public void line8tr()
    {
        linet = false;
        line6t = false;
        line7t = false;
        line8t = true;
        line9t = false;
        line10t = false;
    }

    public void line9tr()
    {
        linet = false;
        line6t = false;
        line7t = false;
        line8t = false;
        line9t = true;
        line10t = false;
    }

    public void line10tr()
    {
        linet = false;
        line6t = false;
        line7t = false;
        line8t = false;
        line9t = false;
        line10t = true;
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculate : MonoBehaviour
{
    public InputField Grade1;
    public InputField Credit1;
    public InputField Grade2;
    public InputField Credit2;
    public TextMeshProUGUI InputText;
    bool line2t = false;

    public void Calc()
    {
        float gred1 = float.Parse(Grade1.text);
        float gred2 = float.Parse(Grade1.text);
        float cred1 = float.Parse(Credit1.text);
        float cred2 = float.Parse(Credit1.text);

        if (line2t == true)
        {
            InputText.text = ((line1() + line2()) / (cred1 + cred2)).ToString();
        }
        else
        {
            InputText.text = (line1() / cred1).ToString();
        }

        float line1()
        {
            return (cred1 * gred1);
        }

        float line2()
        {
            return (cred2 * gred2);
        }
    }
    public void line2true()
    {
        InputText.text = null;
        line2t = true;
    }
    public void line2false()
    {
        InputText.text = null;
        line2t = false;
    }
}
