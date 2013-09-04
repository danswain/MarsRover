using System.Diagnostics;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsRover.AcceptanceTests.Steps
{
	[Binding]
	public class MarsRoverSteps
	{
		private Process _marsRoverSquadControlApp;

		[Given(@"I have a RoverRoverSquadControl")]
		public void GivenIHaveARoverRoverSquadControl()
		{
			MarsRoverSquadControl();
		}

		[When(@"I enter the (.*) command")]
		[Given(@"I enter the command (.*)")]
		public void GivenIEnterTheCommand(string command)
		{
			InputCommand(command);
		}

		[Then(@"the output should be (.*)")]
		public void ThenTheOutputShouldBe(string output)
		{
			Assert.That(GetOutput(), Is.EqualTo(output));
		}

		private void InputCommand(string command)
		{
			_marsRoverSquadControlApp.StandardInput.Write(command);
		}

		private void MarsRoverSquadControl()
		{
			_marsRoverSquadControlApp = new Process();
			_marsRoverSquadControlApp.StartInfo.UseShellExecute = false;
			_marsRoverSquadControlApp.StartInfo.RedirectStandardOutput = true;
			_marsRoverSquadControlApp.StartInfo.RedirectStandardInput = true;
			_marsRoverSquadControlApp.StartInfo.FileName = "MarsRover.SquadControlApp.exe";
			_marsRoverSquadControlApp.Start();
			_marsRoverSquadControlApp.WaitForExit();
		}

		private string GetOutput()
		{
			return _marsRoverSquadControlApp.StandardOutput.ReadToEnd();
		}
	}
}
