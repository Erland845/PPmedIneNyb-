using System;

public class Circle : Figur
{
    public int Radius { get; set; }

    public Circle(int radius, string name) 
        : base(name)
    {
        Radius = radius;
        CircleCircumference();
        CalculateArea();

    }

    public void CalculateArea()
    {
        var R2 = Radius * Radius;
        var pi = Math.PI;
        Area = R2 * pi;
    }

    public void CircleCircumference()
    {
        var Pi2 = 2 * Math.PI;
        Circumference = Pi2 * Radius;
    }
}



//sirkel = Radius ^ 2 * pi
//sirkel (circumference) = pi^2 * Radius
//rektankel = bredde * høyde
//square = bredde * høyde