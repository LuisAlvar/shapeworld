using ShapeWold.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShapeWold.Domain.Collections{
  public class ShapeArray{
    public void DimensionalArray(){
      //1-D
      Shape[] shape1 = new Shape[10];
      Shape[] shape2 =  new Shape[]{new Square(2)};
      
      //2-D
      Shape[,] array3 = new Shape[2,2];
      Shape[,] array4 = new Shape[,]{
        {new Square(1), new Square(2)},
        {new Square(3), new Square(4)}
      };

      // Shape[,,] array6 = new Shape[,,]{
      //   {{new Shape(), new Shape(), new Shape()},{},{}},
      //   {},
      //   {}
      // }

      //JAGGED ARRAY
      //its an array that contains arrays. 
      //its an array of 10 cells of arrays.
      Shape[][] shape7 = new Shape[10][];
      Shape[][] shapes8 = new Shape[][]{
        new Rectangle[10],
        new []{new Sphere(3), new Sphere(4)}
      };
      System.Console.WriteLine(shapes8[1][1]);
    }

    public void MyList(){
      List<Shape> shaped = new List<Shape>();
      List<Shape> shaped2 = new List<Shape>(){new Cube(3), new Cube(4)};
      List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
      List<Shape[][,,]> shaped4 = new List<Shape[][,,]>(){
        new Shape[5][,,]
      };
      System.Console.WriteLine();
      //This is called a precidate function 
      System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 12));
      System.Console.WriteLine(shaped2.FindIndex(e => e.NumberOfEdges == 12));
      System.Console.WriteLine(shaped2.FirstOrDefault());
      //AddRange -> your add a list to a list 
      
      try
      {
          //WE are making three assumptions
          /*
            shpaed2 exist 
            the range to 100 is availabe 
            the class Rectangle exists 
           */
          shaped2[100] = new Rectangle(3,3);
      }
      catch (System.NullReferenceException){
        /*
          This bubbles up the error to the Program.cs main function 
         */
        throw; //option1 - not my problem 
      }
      catch (System.ArgumentOutOfRangeException){
        
           shaped2.Add( new Rectangle(3,3) );
      }
      catch (System.Exception ex)
      {
          throw new System.Exception("dsd", ex); //you are telling the developer that there is an error but 
          /*
            it will not tell you exactly where the logic error occured 
           */         
      }
      finally{
        System.GC.Collect();
      }

      //Remove
      /*

       */
    }

    public void MyDictionary(){
      //A key value should always be Value Types not a 
      //Reference Types
      Dictionary<string, Shape> shaped = new Dictionary<string, Shape>();

      //Guid -> 

      Dictionary<string, List<Shape>> shaped2 = new Dictionary<string, List<Shape>>{
        {"square", new List<Shape>()},
      };

      //READ
      System.Console.WriteLine(shaped2["square"]);
      shaped2.Select(d => d.Key == "square");

      //Write
      shaped2["square"] = new List<Shape>(); //add and update
      //If it finds square  it wil throw you an error, because we only add and not updata
      //shaped2.Add("square", new List<Shape>()); -> dont do this 

    } 

  }
}