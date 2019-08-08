using Xunit;
using ShapeWold.Domain.Models;

namespace ShapeWorld.Testing{
  public class RectangleTest{
    [Fact]
    public void Test_Edges(){
      //arrange 
      var rectangle = new Rectangle(3,2);
      var expected = 4;

      //act
      var actual = rectangle.NumberOfEdges;

      //assert
      Assert.True(expected == actual);
    }
  }
}