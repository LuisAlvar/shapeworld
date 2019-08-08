using System;

namespace ShapeWold.Domain.Models{
  public class Sphere: Shape{
    public Sphere(int rad): base(1){
      Radius = rad;
    }

    public double Circumference(){
      return 2 * Math.PI * Radius;
    }

    public override double Perimeter(){
      return 0;
    }

    public override double Area(){
      return 4 * Math.PI * Math.Pow(Radius, 2);
    }

    public override double Volume(){
      return (4/3.0) * Math.PI * Math.Pow(Radius, 3);
    }
  }
}