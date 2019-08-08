namespace ShapeWold.Domain.Models{
  public class Cube: Prism{
    public Cube(int dim): base(width: dim, length: dim, height: dim){
    }

    public override double Perimeter(){
      return NumberOfEdges*(Width);
    }

    public override double Area(){
      return 6*(Width*Width);
    }
    
  }
}