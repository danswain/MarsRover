using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRover.AcceptanceTests.Steps
{
	[Binding]
	public class MarsRoverSteps
	{
		[Given(@"I have a RoverRoverSquadControl")]
		public void GivenIHaveARoverRoverSquadControl()
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I enter the (.*) command")]
		[Given(@"I enter the command (.*)")]
		public void GivenIEnterTheCommand(string command)
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"the output should be (.*)")]
		public void ThenTheOutputShouldBe(string output)
		{
			ScenarioContext.Current.Pending();
		}

	}
}
