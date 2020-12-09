using FluentAssertions;
using Xunit;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Can_create_a_point_with_two_arguments()
        {
            var point = new Point(1,3);
            
            point.X.Should().Be(1);
            point.Y.Should().Be(3);
        }

        [Fact]
        public void Can_create_a_point_without_arguments_and_coordinates_are_1()
        {
            var point = new Point();

            point.X.Should().Be(1);
            point.Y.Should().Be(1);
        }

        [Fact]
        public void Distance_of_a_given_point_is_calculated_correctly()
        {
            //Arrange
            var point = new Point(3, 4);
            //Act
            var distance = point.Distance();
            //Assert
            distance.Should().Be(5);
        }
    }
}
