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

/*

multiple inheritence is not allowed in C#
only interfernces 
- its a collection of signetures 

An interference does not carry if you implement the 
methods. Whereas an abstract class you must implment 
the method in the subclass 

public class Cube: shape, IThreeD{
  double IThreeD.Height {get => throw new System.NotImplementedException}

  public override double Surface(){
    return 0;
  }
  double IThreeD.Volume(){
    throw new System.NotImplementedException();
  }
}



 */