using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{

    private void Start()
    {
        shapeType = "Cube";
        shapeColor = "Red";
    }

    protected override void ShapeClicked() // POLYMORPHISM
    {
        shapeClicked = 1;
        Debug.Log(shapeColor + " " + shapeType + " clicked!");
    }
}
