using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeType;
    protected string shapeColor;

    private int v_shapeClicked;
    public int shapeClicked {
        get { return v_shapeClicked; }
        set
        {
            if (value == 1 || value == 0) // записываем только 0 или 1, другие значени€ не принимаем
            {
                if (v_shapeClicked != 1) // измен€ем только если уже не 1
                {
                    v_shapeClicked = value; // записываем в переменную бэкап
                }
            }
            else
            {
                Debug.LogError("You can set value only 0 or 1!");
            }
        }
    }

    private void OnMouseDown()
    {
        ShapeClicked();
    }

    protected virtual void ShapeClicked()
    {
        shapeClicked = 1;
        Debug.Log("Shape clicked " + v_shapeClicked);
    }

}
