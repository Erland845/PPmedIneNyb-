using System;

public class Square : Figur
{
	public int Width {  get; set; }
	public int Height { get; set; }

	public Square(int width, int height, string name)
		: base(name)
	{
		Width = width;
		Height = height;
		SquareCircumference();
		SquareArea();

    }
	public void SquareCircumference()
    {
        var W2 = Width * 2;
        var H2 = Height * 2;
        Circumference = W2 + H2;
	}
	public void SquareArea()
	{
		Area = Width * Height;
	}
}
