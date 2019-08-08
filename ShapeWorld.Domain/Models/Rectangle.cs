namespace ShapeWold.Domain.Models{
  public class Rectangle: Shape{
    public Rectangle(int width, int length): base(4){
      Length = length;
      Width = width;
    }

    public override double Perimeter(){
      return 2 * (Length + Width);
    }

    public override double Area(){
      return (Width*Length);
    }
    
    public override double Volume(){
      return (Width * Length * Height);
    }


  }
}