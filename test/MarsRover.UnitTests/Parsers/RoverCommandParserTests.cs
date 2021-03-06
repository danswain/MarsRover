﻿using System.Collections.Generic;
using System.Linq;
using MarsRover.Parsers;
using NUnit.Framework;

namespace MarsRover.UnitTests.Parsers
{
	[TestFixture]
	public class RoverCommandParserTests
	{
		[Test]
		public void Should_return_1_RoverCommand()
		{
			//Given
			var commandStrings = new List<string> {"5 5", "1 1 N", "MM"};
			//When
			var roverCommands = ParseRoverCommands.From(commandStrings);

			//Then
			Assert.That(roverCommands.Count(), Is.EqualTo(1), "Should parser only 1 RoverCommand");
			
			var robotCommand = roverCommands.First();

			Assert.That(robotCommand.StartingPosition, Is.EqualTo(ParsePosition.From("1 1 N")));
		}
	}
}