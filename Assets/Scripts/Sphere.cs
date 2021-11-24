using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        shapeType = "Sphere";
        shapeColor = "Green";
    }

    protected override void ShapeClicked()
    {
        shapeClicked = 1;
        Debug.Log("Toxic " + shapeColor + " " + shapeType + " clicked!");
    }
}
