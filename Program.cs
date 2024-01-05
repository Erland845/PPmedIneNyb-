namespace PPmedIneNybø
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Figur> Figurer = new List<Figur>
            {
                new Square(20, 30, "rektangel"),
                new Square(12, 12, "Kvadrat"),
                new Circle(20, "Sirkel"),
                new Square(40, 30, "rektangel2"),
                new Square(50, 50, "Kvadrat2"),
                new Circle(15, "Sirkel2"),

            };
            foreach (Figur f in Figurer)
            {
                f.GetCircumference();
                f.GetArea();
                Console.WriteLine();
            }
        }
    }
}

























//Area and circumference
//Du skal lage en kalkulator som skal beregne areal og omkrets til en sirkel,
//rektangel, og et kvadrat ved hjelp av arv.
//Start med å finne en baseklasse med de egenskapene som er felles,
//hver klasse må så ha sin egen implementasjon for beregningene.

//foreach(var shape in shapes)
//{
  //Console.WriteLine(shape.GetCircumference());
  //Console.WriteLine(shape.GetArea());
//}


//Skal printe ut noe som feks:

//circle circumference is 34
//rectangle circumference is 44
//square circumference is 55

//circle area is 34
//rectangle areais 44
//square area is 55