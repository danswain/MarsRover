using System.Diagnostics;

namespace MarsRover.AcceptanceTests.Steps
{
	public class MarsRoverSquadControlApp
	{
		private Process _marsRoverSquadControlApp;


		public MarsRoverSquadControlApp()
		{
			_marsRoverSquadControlApp = new Process();
			_marsRoverSquadControlApp.StartInfo.UseShellExecute = false;
			_marsRoverSquadControlApp.StartInfo.RedirectStandardOutput = true;
			_marsRoverSquadControlApp.StartInfo.RedirectStandardInput = true;
			_marsRoverSquadControlApp.StartInfo.FileName = "MarsRover.SquadControlApp.exe";
			_marsRoverSquadControlApp.Start();
			//_marsRoverSquadControlApp.WaitForExit();
		}

		public void InputCommand(string command)
		{
			_marsRoverSquadControlApp.StandardInput.WriteLine(command);
		}

		public string GetOutput()
		{
			return _marsRoverSquadControlApp.StandardOutput.ReadToEnd();
		}
	}
}