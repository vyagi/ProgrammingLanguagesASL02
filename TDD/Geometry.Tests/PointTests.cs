using FluentAssertions;
using Xunit;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Can_create_a_point_with_two_arguments()
        {
            //Arrange
            //Act
            var point = new Point(1,3);
            
            //Assert
            point.X.Should().Be(1);
            point.Y.Should().Be(3);
        }
    }
}
