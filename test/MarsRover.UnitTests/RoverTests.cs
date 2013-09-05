using Moq;
using NUnit.Framework;

namespace MarsRover.UnitTests
{
	[TestFixture]
	public class RoverTests
	{
		[TestCase(Instruction.M, 0, 1, Orientation.N)]
		[TestCase(Instruction.L, 0, 0, Orientation.W)]
		[TestCase(Instruction.R, 0, 0, Orientation.E)]
		public void Should_be_able_to_go(Instruction instruction, int xCoordinate, int yCoordinate, Orientation orientation)
		{
			//Given
			var output = new Mock<IOutput>();
			var startingPosition = new Position()
				{
					Coordinate = new Coordinate(0,0),
					Orientation = Orientation.N
				};
			var rover = new Rover(startingPosition, output.Object, new NavigationSystem());
			//When
			rover.Send(instruction);
			//Then
			Assert.That(rover.CurrentPosition.Coordinate.X, Is.EqualTo(xCoordinate), " X Coordinate");
			Assert.That(rover.CurrentPosition.Coordinate.Y, Is.EqualTo(yCoordinate), " Y Coordinate");
			Assert.That(rover.CurrentPosition.Orientation, Is.EqualTo(orientation), "Orientation");
			var outputString = xCoordinate + " " + yCoordinate + " " + orientation.ToString();
			output.Verify(console => console.Debug(It.Is<string>(val=>val == outputString)));
		}
	}
}