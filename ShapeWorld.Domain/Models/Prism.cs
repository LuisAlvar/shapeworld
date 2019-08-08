namespace ShapeWold.Domain.Models{
  public class Prism: Shape{
     public Prism(int width, int length, int height): base(12){
      Width = width;
      Length = length;
      Height = height;
    }


    public override double Perimeter(){
      return (2*Length) + (2*Width);
    }
    public override double Area(){
      return (2*Width*Length) + (2*Length*Height) + (2*Height*Width);
    }
    public override double Volume(){
      return (Width*Length*Height);
    }
  }
}