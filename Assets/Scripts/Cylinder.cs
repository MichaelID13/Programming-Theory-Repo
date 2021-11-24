using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        shapeType = "Cylinder";
        shapeColor = "Blue";
    }

    protected override void ShapeClicked()
    {
        shapeClicked = 1;
        Debug.Log("Tall " + shapeColor + " " + shapeType + " clicked!");
    }
}
