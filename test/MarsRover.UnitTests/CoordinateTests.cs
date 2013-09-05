using NUnit.Framework;

namespace MarsRover.UnitTests
{
	[TestFixture]
	public class CoordinateTests
	{

		[Test]
		public void Should_give_coordinates_0_0_by_default()
		{
			//Given
			var coordinate = new Coordinate();			

			//Then
			Assert.That(coordinate.X, Is.EqualTo(0), "Default X Coordinate is not 0");
			Assert.That(coordinate.Y, Is.EqualTo(0), "Default Y Coordinate is not 0");
		}

		[Test]
		public void Should_give_coordinates_set_in_constructior()
		{
			//Given
			var coordinate = new Coordinate(1,2);

			//Then
			Assert.That(coordinate.X, Is.EqualTo(1), "Default X Coordinate is not 1");
			Assert.That(coordinate.Y, Is.EqualTo(2), "Default Y Coordinate is not 2");
		}


		[Test]
		public void Should_parse_string_5_6()
		{
			//Given
			var coordinateString = "5 6";
			//When
			var parsedCoordinate = Coordinate.Parse(coordinateString);

			//Then
			Assert.That(parsedCoordinate.X, Is.EqualTo(5), "X Coordinate");
			Assert.That(parsedCoordinate.Y, Is.EqualTo(6), "Y Coordinate");
		}

		[TestCase("A B")]
		[TestCase("1 2 3")]
		public void Should__throw_error_for_invalid_coordinate_string(string coordinateString)
		{
				
			var exception = Assert.Throws<InputBoundaryException>(() => Coordinate.Parse(coordinateString));

			Assert.That(exception.Message,Is.EqualTo(coordinateString + " is not a valid coordinate"), "Hasn't thrown exception when given an incorrect coordinate string");
			
		}

		[Test]
		public void Should_be_able_to_compare_2_coordinates()
		{
			var firstCoordinate = new Coordinate(1, 2);
			var secondCoordinate = new Coordinate(1, 2);

			Assert.That(firstCoordinate, Is.EqualTo(secondCoordinate));
		}
	}
}