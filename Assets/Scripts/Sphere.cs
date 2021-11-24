using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    private void Start()
    {
        shapeType = "Sphere";
        shapeColor = "Green";
    }

    protected override void ShapeClicked() // POLYMORPHISM
    {
        shapeClicked = 1;
        Debug.Log("Toxic " + shapeColor + " " + shapeType + " clicked!");
    }
}
