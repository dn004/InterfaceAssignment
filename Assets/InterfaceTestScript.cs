using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{

    void Start()
    {
        Trapezium trapezium = new Trapezium(3, 4, 5, 6, 2);
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();
        
        Circle circle = new Circle(5);
        circle.CalculateArea();
        circle.CalculatePerimeter();

        Nonagon nonagon = new Nonagon(10);
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
    }

    void Update()
    {
        
    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    private float a;
    private float b;
    private float c;
    private float d;
    private float height;
    
    public Trapezium(float a, float b, float c, float d, float height)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.height = height;
    }


    public void CalculateArea()
    {
        float area = ((a + b) / 2) * height;
        Debug.Log("Trapezium Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = a + b + c + d;
        Debug.Log("Trapezium Perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    private float radius;
    
    public Circle(float radius)
    {
        this.radius = radius;
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle Perimeter: " + perimeter);
    }
}

public class Nonagon : IShape
{
    private int numberOfSides;
    private float sideLength;
    
    public Nonagon(float sideLength)
    {
        this.numberOfSides = 9;
        this.sideLength = sideLength;
    }

    public void CalculateArea()
    {
        float area = (9f / 4f) * sideLength * sideLength / Mathf.Tan(Mathf.PI / 9f);
        Debug.Log("Nonagon Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon Perimeter: " + perimeter);
    }

}
