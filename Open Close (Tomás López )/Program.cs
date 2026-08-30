using DemoOpenClosePrinciple;
using Open_Close__Tomás_López__;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3 = new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Rectangulo rectangulo1 = new Rectangulo();
rectangulo1.Base = 5;
rectangulo1.Altura = 2;

Rectangulo rectangulo2= new Rectangulo();
rectangulo2.Base = 10;
rectangulo2.Altura = 2;

Rectangulo rectangulo3 = new Rectangulo();
rectangulo3.Base = 15;
rectangulo3.Altura = 5;

Rombo rombo1 = new Rombo();
rombo1.DiagonalMayor = 10;
rombo1.DiagonalMenor = 5;

Rombo rombo2 = new Rombo();
rombo2.DiagonalMayor = 8;
rombo2.DiagonalMenor = 4;

Rombo rombo3 = new Rombo();
rombo3.DiagonalMayor = 6;
rombo3.DiagonalMenor = 3;




List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(rectangulo1);
shapes.Add(rectangulo2);
shapes.Add(rectangulo3);
shapes.Add(rombo1);
shapes.Add(rombo2);
shapes.Add(rombo3);


var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");