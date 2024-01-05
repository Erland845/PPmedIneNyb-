using System;

public class Figur
{
	protected string Name { get; set; }
	protected double Circumference { get; set; }
	protected double Area { get; set; }


    public Figur(string name) 
	{
		Name = name;

	}
	public void GetCircumference() 
	{
		var omkrets = Circumference.ToString("#.##");
        Console.WriteLine($"{Name} circumference is {omkrets}");
    }

	public void GetArea()
    {
        var Areal = Area.ToString("#.##");
		Console.WriteLine($"{Name} area is {Areal}");
	}
}
