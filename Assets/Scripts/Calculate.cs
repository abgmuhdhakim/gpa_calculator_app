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
    public InputField Grade3;
    public InputField Credit3;
    public InputField Grade4;
    public InputField Credit4;
    public InputField Grade5;
    public InputField Credit5;
    public InputField Grade6;
    public InputField Credit6;
    public InputField Grade7;
    public InputField Credit7;
    public InputField Grade8;
    public InputField Credit8;
    public InputField Grade9;
    public InputField Credit9;
    public InputField Grade10;
    public InputField Credit10;
    public TextMeshProUGUI OutputText;

    bool linet = false;
    bool line2t = false;
    bool line3t = false;
    bool line4t = false;
    bool line5t = true;
    bool line6t = false;
    bool line7t = false;
    bool line8t = false;
    bool line9t = false;
    bool line10t = false;

    public void Calc()
    {
        float cred1 = float.Parse(Credit1.text);
        float gred1 = float.Parse(Grade1.text);
        
        if (linet == true)
        {
            OutputText.text = (line1() / cred1).ToString("F2");
        }
        else if (line2t == true)
        {
            OutputText.text = ((line1() + line2()) / total2()).ToString("F2");
        }
        else if (line3t == true)
        {
            OutputText.text = ((line1() + line2() + line3()) / total3()).ToString("F2");
        }
        else if (line4t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4()) / total4()).ToString("F2");
        }
        else if (line5t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4() + line5()) / total5()).ToString("F2");
        }
        else if (line6t == true)
        { 
            OutputText.text = ((line1() + line2() + line3() + line4() + line5() + line6())/ total6()).ToString("F2");
        }
        else if (line7t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4() + line5() + line6() + line7())/ total7()).ToString("F2");
        }
        else if (line8t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4() + line5() + line6() + line7() + line8())/ total8()).ToString("F2");
        }
        else if (line9t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4() + line5() + line6() + line7() + line8() + line9())/ total9()).ToString("F2");
        }
        else if (line10t == true)
        {
            OutputText.text = ((line1() + line2() + line3() + line4() + line5() + line6() + line7() + line8() + line9() + line10())/ total10()).ToString("F2");
        }

        float line1()
        {
            return (cred1 * gred1);
        }

        float line2()
        {
            float cred2 = float.Parse(Credit2.text);
            float gred2 = float.Parse(Grade2.text);
            return (cred2 * gred2);
        }
        float line3()
        {
            float cred3 = float.Parse(Credit3.text);
            float gred3 = float.Parse(Grade3.text);
            return (cred3 * gred3);
        }
        float line4()
        {
            float cred4 = float.Parse(Credit4.text);
            float gred4 = float.Parse(Grade4.text);
            return (cred4 * gred4);
        }
        float line5()
        {
            float cred5 = float.Parse(Credit5.text);
            float gred5 = float.Parse(Grade5.text);
            return (cred5 * gred5);
        }
        float line6()
        {
            float cred6 = float.Parse(Credit6.text);
            float gred6 = float.Parse(Grade6.text);
            return (cred6 * gred6);
        }
        float line7()
        {
            float gred7 = float.Parse(Grade7.text);
            float cred7 = float.Parse(Credit7.text);
            return (cred7 * gred7);
        }
        float line8()
        {
            float gred8 = float.Parse(Grade8.text);
            float cred8 = float.Parse(Credit8.text);
            return (cred8 * gred8);
        }
        float line9()
        {
            float gred9 = float.Parse(Grade9.text);
            float cred9 = float.Parse(Credit9.text);
            return (cred9 * gred9);
        }
        float line10()
        {
            float gred10 = float.Parse(Grade10.text);
            float cred10 = float.Parse(Credit10.text);
            return (cred10 * gred10);
        }

        float total2()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            return (cred1 + cred2);
        }
        float total3()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            return (cred1 + cred2 + cred3);
        }
        float total4()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            return (cred1 + cred2 + cred3 + cred4);
        }
        float total5()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            float cred5 = float.Parse(Credit5.text);
            return (cred1 + cred2 + cred3 + cred4 + cred5);
        }
        float total6()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            float cred5 = float.Parse(Credit5.text);
            float cred6 = float.Parse(Credit6.text);
            return (cred1 + cred2 + cred3 + cred4 + cred5 + cred6);
        }
        float total7()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            float cred5 = float.Parse(Credit5.text);
            float cred6 = float.Parse(Credit6.text);
            float cred7 = float.Parse(Credit7.text);
            return (cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7);
        }
        float total8()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            float cred5 = float.Parse(Credit5.text);
            float cred6 = float.Parse(Credit6.text);
            float cred7 = float.Parse(Credit7.text);
            float cred8 = float.Parse(Credit8.text);
            return (cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8);
        }
        float total9()
        {
            float cred1 = float.Parse(Credit1.text);
            float cred2 = float.Parse(Credit2.text);
            float cred3 = float.Parse(Credit3.text);
            float cred4 = float.Parse(Credit4.text);
            float cred5 = float.Parse(Credit5.text);
            float cred6 = float.Parse(Credit6.text);
            float cred7 = float.Parse(Credit7.text);
            float cred8 = float.Parse(Credit8.text);
            float cred9 = float.Parse(Credit9.text);
            return (cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8 + cred9);
        }
        float total10()
        {
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
            return (cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8 + cred9 + cred10);
        }
    }

    public void linetr()
    {
        linet = true;
        line2t = false;
        OutputText.text = null;
    }
    public void line2tr()
    {
        linet = false;
        line2t = true;
        line3t = false;
        OutputText.text = null;
    }
    public void line3tr()
    {
        line2t = false;
        line3t = true;
        line4t = false;
        OutputText.text = null;
    }
    public void line4tr()
    {
        line3t = false;
        line4t = true;
        line5t = false;
        OutputText.text = null;
    }
    public void line5tr()
    {
        line4t = false;
        line5t = true;
        line6t = false;
        OutputText.text = null;
    }
    public void line6tr()
    {
        line5t = false;
        line6t = true;
        line7t = false;
        OutputText.text = null;
    }
    public void line7tr()
    {
        line6t = false;
        line7t = true;
        line8t = false;
        OutputText.text = null;
    }
    public void line8tr()
    {
        line7t = false;
        line8t = true;
        line9t = false;
        OutputText.text = null;
    }
    public void line9tr()
    {
        line8t = false;
        line9t = true;
        line10t = false;
        OutputText.text = null;
    }
    public void line10tr()
    {
        line9t = true;
        line10t = false;
        OutputText.text = null;
    }
}
