using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MarsRover.AcceptanceTests.Helpers;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsRover.AcceptanceTests.Steps
{
	[Binding]
	public class RoverSteps
	{
		private MarsRoverSquadControlApp _marsRoverSquadControlApp;


		[Given(@"I have a RoverRoverSquadControl")]
		public void GivenIHaveARoverRoverSquadControl()
		{
			_marsRoverSquadControlApp = new MarsRoverSquadControlApp();
		}

		[When(@"I enter the (.*) command")]
		[Given(@"I enter the command (.*)")]
		public void GivenIEnterTheCommand(string command)
		{
			_marsRoverSquadControlApp.InputCommand(command);
		}

		[Then(@"the output should be (.*)")]
		public void ThenTheOutputShouldBe(string output)
		{
			Assert.That(_marsRoverSquadControlApp.GetOutput(), Is.EqualTo(output));
		}


		[When(@"I send the the commands:")]
		public void WhenISendTheTheCommands(Table table)
		{
			var commands = table.AsRoverCommands();
			_marsRoverSquadControlApp.InputCommands(commands);
		}

		[Then(@"the result should be")]
		public void ThenTheResultShouldBe(Table table)
		{
			var outputCollection = _marsRoverSquadControlApp.GetOutputAsCollection();
			var expected = table.AsRoverCommands();
			CollectionAssert.AreEqual(expected, outputCollection);
		}
	}
}
