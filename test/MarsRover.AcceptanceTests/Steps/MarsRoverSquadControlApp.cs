using System;
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
			_marsRoverSquadControlApp.StartInfo.RedirectStandardError = true;
			_marsRoverSquadControlApp.StartInfo.FileName = "MarsRover.SquadControlApp.exe";
			_marsRoverSquadControlApp.Start();
			
		}

		public void InputCommand(string command)
		{
			_marsRoverSquadControlApp.StandardInput.WriteLine(command);
		}

		public string GetOutput()
		{
			var output = _marsRoverSquadControlApp.StandardOutput.ReadToEnd();
			Console.WriteLine(_marsRoverSquadControlApp.StandardError.ReadToEnd());			
			_marsRoverSquadControlApp.WaitForExit();
			return output;
		}
	}
}