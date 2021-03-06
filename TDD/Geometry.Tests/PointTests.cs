﻿using FluentAssertions;
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
            var point = new Point(3, 4);
            
            var distance = point.Distance();
            
            distance.Should().Be(5);
        }

        [Fact]
        public void Distance_of_a_given_point_from_another_point_is_calculated_correctly()
        {
            var point1 = new Point(1, 1);
            var point2 = new Point(4, 5);
            
            var distance = point1.Distance(point2);
            
            distance.Should().Be(5);
        }

        [Fact]
        public void Distance_between_two_points_is_calculated_correctly()
        {
            var point1 = new Point(1, 1);
            var point2 = new Point(4, 5);

            var distance = Point.Distance(point1, point2);

            distance.Should().Be(5);
        }

        [Fact]
        public void ToString_returns_human_readable_representation()
        {
            var point = new Point(-4, 5);

            var text = point.ToString();

            text.Should().Be("(-4,5)");
        }

        [Fact]
        public void Reflect_method_returns_proper_result_when_reflecting_along_y()
        {
            var point = new Point(-4, 5);

            var reflectedPoint = point.Reflect(Point.ReflectionType.Y);

            reflectedPoint.X.Should().Be(4);
            reflectedPoint.Y.Should().Be(5);
        }

        [Fact]
        public void Reflect_method_returns_proper_result_when_reflecting_along_x()
        {
            var point = new Point(-4, 5);

            var reflectedPoint = point.Reflect(Point.ReflectionType.X);

            reflectedPoint.X.Should().Be(-4);
            reflectedPoint.Y.Should().Be(-5);
        }

        [Fact]
        public void Reflect_method_returns_proper_result_when_reflecting_around_origin()
        {
            var point = new Point(-4, 5);

            var reflectedPoint = point.Reflect(Point.ReflectionType.Origin);

            reflectedPoint.X.Should().Be(4);
            reflectedPoint.Y.Should().Be(-5);
        }
    }
}
