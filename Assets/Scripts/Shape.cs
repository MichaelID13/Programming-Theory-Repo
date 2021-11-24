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
            if (value == 1 || value == 0) // ���������� ������ 0 ��� 1, ������ �������� �� ���������
            {
                if (v_shapeClicked != 1) // �������� ������ ���� ��� �� 1
                {
                    v_shapeClicked = value; // ���������� � ���������� �����
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
