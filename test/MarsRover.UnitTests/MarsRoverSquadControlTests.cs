using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace MarsRover.UnitTests
{
	[TestFixture]
	public class MarsRoverSquadControlTests
	{

		[Test]
		public void Should_write_to_output()
		{
			//Given
			var mockOutput = new Mock<IOutput>();
			var roverSquadControl = new MarsRoverSquadControl(mockOutput.Object);
			var input = new List<string>()
				{"5 5","1 1 N", "M"};

			//When
			roverSquadControl.SendCommand(input.AsEnumerable());

			//Then

			mockOutput.Verify(output => output.Debug(It.Is<string>(outputValue => outputValue == "1 2 N")));
		}
	}
}