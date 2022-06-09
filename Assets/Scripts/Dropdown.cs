using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dropdown : MonoBehaviour
{
    public float Line1, Line2, Line3, Line4, Line5, Line6, Line7, Line8, Line9, Line10;
    [SerializeField] InputField _1;
    void Start()
    {
        _1.text = (4.00f).ToString();
    }

    public void GradePoint1(int x)
    {
        if (x == 0)
        {
            Line1 = 0.00f;
        }
        else if (x == 1)
        {
            Line1 = float.Parse(_1.text);
        }
        else if (x == 2)
        {
            Line1 = 3.75f;
        }
        else if (x == 3)
        {
            Line1 = 3.50f;
        }
        else if (x == 4)
        {
            Line1 = 3.25f;
        }
        else if (x == 5)
        {
            Line1 = 3.00f;
        }
        else if (x == 6)
        {
            Line1 = 2.75f;
        }
        else if (x == 7)
        {
            Line1 = 2.50f;
        }
        else if (x == 8)
        {
            Line1 = 2.25f;
        }
        else if (x == 9)
        {
            Line1 = 2.00f;
        }
        else if (x == 10)
        {
            Line1 = 1.00f;
        }
        else
        {
           Line1 = 0.00f;
        }
    }
    public void GradePoint2(int x)
    {
        if (x == 0)
        {
            Line2 = 0.00f;
        }
        else if (x == 1)
        {
            Line2 = 4.00f;
        }
        else if (x == 2)
        {
            Line2 = 3.75f;
        }
        else if (x == 3)
        {
            Line2 = 3.50f;
        }
        else if (x == 4)
        {
            Line2 = 3.25f;
        }
        else if (x == 5)
        {
            Line2 = 3.00f;
        }
        else if (x == 6)
        {
            Line2 = 2.75f;
        }
        else if (x == 7)
        {
            Line2 = 2.50f;
        }
        else if (x == 8)
        {
            Line2 = 2.25f;
        }
        else if (x == 9)
        {
            Line2 = 2.00f;
        }
        else if (x == 10)
        {
            Line2 = 1.00f;
        }
        else
        {
           Line2 = 0.00f;
        }
    }
    public void GradePoint3(int x)
    {
        if (x == 0)
        {
            Line3 = 0.00f;
        }
        else if (x == 1)
        {
            Line3 = 4.00f;
        }
        else if (x == 2)
        {
            Line3 = 3.75f;
        }
        else if (x == 3)
        {
            Line3 = 3.50f;
        }
        else if (x == 4)
        {
            Line3 = 3.25f;
        }
        else if (x == 5)
        {
            Line3 = 3.00f;
        }
        else if (x == 6)
        {
            Line3 = 2.75f;
        }
        else if (x == 7)
        {
            Line3 = 2.50f;
        }
        else if (x == 8)
        {
            Line3 = 2.25f;
        }
        else if (x == 9)
        {
            Line3 = 2.00f;
        }
        else if (x == 10)
        {
            Line3 = 1.00f;
        }
        else
        {
           Line3 = 0.00f;
        }
    }
    public void GradePoint4(int x)
    {
        if (x == 0)
        {
            Line4 = 0.00f;
        }
        else if (x == 1)
        {
            Line4 = 4.00f;
        }
        else if (x == 2)
        {
            Line4 = 3.75f;
        }
        else if (x == 3)
        {
            Line4 = 3.50f;
        }
        else if (x == 4)
        {
            Line4 = 3.25f;
        }
        else if (x == 5)
        {
            Line4 = 3.00f;
        }
        else if (x == 6)
        {
            Line4 = 2.75f;
        }
        else if (x == 7)
        {
            Line4 = 2.50f;
        }
        else if (x == 8)
        {
            Line4 = 2.25f;
        }
        else if (x == 9)
        {
            Line4 = 2.00f;
        }
        else if (x == 10)
        {
            Line4 = 1.00f;
        }
        else
        {
           Line4 = 0.00f;
        }
    }
    public void GradePoint5(int x)
    {
        if (x == 0)
        {
            Line5 = 0.00f;
        }
        else if (x == 1)
        {
            Line5 = 4.00f;
        }
        else if (x == 2)
        {
            Line5 = 3.75f;
        }
        else if (x == 3)
        {
            Line5 = 3.50f;
        }
        else if (x == 4)
        {
            Line5 = 3.25f;
        }
        else if (x == 5)
        {
            Line5 = 3.00f;
        }
        else if (x == 6)
        {
            Line5 = 2.75f;
        }
        else if (x == 7)
        {
            Line5 = 2.50f;
        }
        else if (x == 8)
        {
            Line5 = 2.25f;
        }
        else if (x == 9)
        {
            Line5 = 2.00f;
        }
        else if (x == 10)
        {
            Line5 = 1.00f;
        }
        else
        {
           Line5 = 0.00f;
        }
    }
    public void GradePoint6(int x)
    {
        if (x == 0)
        {
            Line6 = 0.00f;
        }
        else if (x == 1)
        {
            Line6 = 4.00f;
        }
        else if (x == 2)
        {
            Line6 = 3.75f;
        }
        else if (x == 3)
        {
            Line6 = 3.50f;
        }
        else if (x == 4)
        {
            Line6 = 3.25f;
        }
        else if (x == 5)
        {
            Line6 = 3.00f;
        }
        else if (x == 6)
        {
            Line6 = 2.75f;
        }
        else if (x == 7)
        {
            Line6 = 2.50f;
        }
        else if (x == 8)
        {
            Line6 = 2.25f;
        }
        else if (x == 9)
        {
            Line6 = 2.00f;
        }
        else if (x == 10)
        {
            Line6 = 1.00f;
        }
        else
        {
           Line6 = 0.00f;
        }
    }
    public void GradePoint7(int x)
    {
        if (x == 0)
        {
            Line7 = 0.00f;
        }
        else if (x == 1)
        {
            Line7 = 4.00f;
        }
        else if (x == 2)
        {
            Line7 = 3.75f;
        }
        else if (x == 3)
        {
            Line7 = 3.50f;
        }
        else if (x == 4)
        {
            Line7 = 3.25f;
        }
        else if (x == 5)
        {
            Line7 = 3.00f;
        }
        else if (x == 6)
        {
            Line7 = 2.75f;
        }
        else if (x == 7)
        {
            Line7 = 2.50f;
        }
        else if (x == 8)
        {
            Line7 = 2.25f;
        }
        else if (x == 9)
        {
            Line7 = 2.00f;
        }
        else if (x == 10)
        {
            Line7 = 1.00f;
        }
        else
        {
           Line7 = 0.00f;
        }
    }
    public void GradePoint8(int x)
    {
        if (x == 0)
        {
            Line8 = 0.00f;
        }
        else if (x == 1)
        {
            Line8 = 4.00f;
        }
        else if (x == 2)
        {
            Line8 = 3.75f;
        }
        else if (x == 3)
        {
            Line8 = 3.50f;
        }
        else if (x == 4)
        {
            Line8 = 3.25f;
        }
        else if (x == 5)
        {
            Line8 = 3.00f;
        }
        else if (x == 6)
        {
            Line8 = 2.75f;
        }
        else if (x == 7)
        {
            Line8 = 2.50f;
        }
        else if (x == 8)
        {
            Line8 = 2.25f;
        }
        else if (x == 9)
        {
            Line8 = 2.00f;
        }
        else if (x == 10)
        {
            Line8 = 1.00f;
        }
        else
        {
           Line8 = 0.00f;
        }
    }
    public void GradePoint9(int x)
    {
        if (x == 0)
        {
            Line9 = 0.00f;
        }
        else if (x == 1)
        {
            Line9 = 4.00f;
        }
        else if (x == 2)
        {
            Line9 = 3.75f;
        }
        else if (x == 3)
        {
            Line9 = 3.50f;
        }
        else if (x == 4)
        {
            Line9 = 3.25f;
        }
        else if (x == 5)
        {
            Line9 = 3.00f;
        }
        else if (x == 6)
        {
            Line9 = 2.75f;
        }
        else if (x == 7)
        {
            Line9 = 2.50f;
        }
        else if (x == 8)
        {
            Line9 = 2.25f;
        }
        else if (x == 9)
        {
            Line9 = 2.00f;
        }
        else if (x == 10)
        {
            Line9 = 1.00f;
        }
        else
        {
           Line9 = 0.00f;
        }
    }
    public void GradePoint10(int x)
    {
        if (x == 0)
        {
            Line10 = 0.00f;
        }
        else if (x == 1)
        {
            Line10 = 4.00f;
        }
        else if (x == 2)
        {
            Line10 = 3.75f;
        }
        else if (x == 3)
        {
            Line10 = 3.50f;
        }
        else if (x == 4)
        {
            Line10 = 3.25f;
        }
        else if (x == 5)
        {
            Line10 = 3.00f;
        }
        else if (x == 6)
        {
            Line10 = 2.75f;
        }
        else if (x == 7)
        {
            Line10 = 2.50f;
        }
        else if (x == 8)
        {
            Line10 = 2.25f;
        }
        else if (x == 9)
        {
            Line10 = 2.00f;
        }
        else if (x == 10)
        {
            Line10 = 1.00f;
        }
        else
        {
           Line10 = 0.00f;
        }
    }
}
