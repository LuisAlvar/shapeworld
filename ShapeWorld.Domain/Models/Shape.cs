using System;

namespace ShapeWold.Domain.Models{//This the project we are working on 
  public abstract class Shape{
    //fields -> a variable at the class scope 
    
    // private int numberOfEdges; //backing field variable 
    
    // //properties -> is a field with methods
    // public int NumberOfEdges {
    //   get{
    //     return numberOfEdges;
    //   }
    //   private set{
    //     numberOfEdges = value;
    //   }
    // }

    //Properties -> is a field with methods -> there are methods 
    public int NumberOfEdges{get;} //this auto creates its own backing field temp. 
    //private set - only inside this case can assign a value to the tem NumberOfEdges variable

    public double Length {get; set;}
    public double Width {get; set;}

    public double Hypotenuse {get; set;}

    public double Radius {get; set;}

    public double Height {get; set;}
    public abstract double Perimeter();

    public abstract double Area();

    public abstract double Volume();



    //Controllers - constructor 
    public Shape(int edges){
      if(edges >= 0){
        NumberOfEdges = edges;
      }
    }

    //methods
    public override string ToString(){
      //.Name -> class Name 
      //This -> this is a reflection 
      //GetType() is the way we enter reflection
      return $"{this.GetType().Name} {NumberOfEdges}";
    }
  }

}