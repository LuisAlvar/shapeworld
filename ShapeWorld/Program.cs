using System;
using ShapeWold.Domain.Models;
using ShapeWold.Domain.Collections;

namespace ShapeWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
           PlayWidthShape();
           ShapeArray sa = new ShapeArray();
           sa.MyList();
        }

        private static void PlayWidthShape(){
          Square b1 = new Square(wh:10);
          Rectangle b2 = new Rectangle(width: 25, length: 10);
          Prism b3 =  new Prism(width: 20, length: 50, height: 15);
          Cube  b4 = new Cube(dim: 12);
          Triangle  b5 = new Triangle(size: 5);
          Sphere b6 = new Sphere(rad: 3);


          System.Console.WriteLine("----Information for b1: Square----");
          Console.WriteLine("Number of Edges: " + b1.NumberOfEdges);
          System.Console.WriteLine("Perimeter: " + b1.Perimeter());
          System.Console.WriteLine("Area: " + b1.Area());
          System.Console.WriteLine("Volumn: " + b1.Volume());

          System.Console.WriteLine("----Information for b2: Rectangle----");
          Console.WriteLine("Number of Edges: " + b2.NumberOfEdges);
          System.Console.WriteLine("Perimeter: " + b2.Perimeter());
          System.Console.WriteLine("Area: " + b2.Area());
          System.Console.WriteLine("Volumn: " + b2.Volume());

          System.Console.WriteLine("----Information for b3: Prism----");
          Console.WriteLine("Number of Edges: " + b3.NumberOfEdges);
          System.Console.WriteLine("Perimeter: " + b3.Perimeter());
          System.Console.WriteLine("Area: " + b3.Area());
          System.Console.WriteLine("Volumn: " + b3.Volume());
   
          System.Console.WriteLine("----Information for b4: Cube----");
          Console.WriteLine("Number of Edges: " + b4.NumberOfEdges);
          System.Console.WriteLine("Perimeter: " + b4.Perimeter());
          System.Console.WriteLine("Area: " + b4.Area());
          System.Console.WriteLine("Volumn: " + b4.Volume());
        
          System.Console.WriteLine("----Information for b5: Triangle----");
          Console.WriteLine("Number of Edges: " + b5.NumberOfEdges);
          System.Console.WriteLine("Perimeter: " + b5.Perimeter());
          System.Console.WriteLine("Area: " + b5.Area());
          System.Console.WriteLine("Volumn: " + b5.Volume());

          System.Console.WriteLine("----Information for b6: Sphere----");
          Console.WriteLine("Number of Edges: " + b6.NumberOfEdges);
          System.Console.WriteLine("Circumference: " + b6.Circumference());
          System.Console.WriteLine("Area: " + b6.Area());
          System.Console.WriteLine("Volumn: " + b6.Volume());   
        }
    }
}
