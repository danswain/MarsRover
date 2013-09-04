using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsRover.AcceptanceTests.Steps
{
	[Binding]
	public class MarsRoverSteps
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
	}
}
