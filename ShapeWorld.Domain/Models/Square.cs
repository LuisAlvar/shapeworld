namespace ShapeWold.Domain.Models{
  public class Square: Rectangle{
    public Square(int wh): base(width: wh, length: wh){
    }

    public override double Perimeter(){
      return 4 * Width;
    }
  }
}