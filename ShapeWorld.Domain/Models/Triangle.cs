using System;

namespace ShapeWold.Domain.Models{
  public class Triangle: Shape{
    public Triangle(double width, double height): base(3){
      Width =  width;
      Height =  height;
      Hypotenuse = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width,2));
    }

    public Triangle(double size): base(3){
      Width = Length = size;
      Hypotenuse = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width,2));
    }

    public override double Perimeter(){
      return (Width + Height + Hypotenuse);
    }

    public override double Area(){
      return (1.0/2)*(Width*Length);
    }

    public override double Volume(){
      return 0;
    }
  }
}