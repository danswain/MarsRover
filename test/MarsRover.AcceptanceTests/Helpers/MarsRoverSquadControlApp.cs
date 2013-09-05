using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MarsRover.AcceptanceTests.Helpers
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
			//_marsRoverSquadControlApp.WaitForExit();
			
		}

		public void InputCommand(string command)
		{
			_marsRoverSquadControlApp.StandardInput.WriteLine(command);
		}

		public string GetOutput()
		{
			var output = _marsRoverSquadControlApp.StandardOutput.ReadToEnd();
			Console.WriteLine(_marsRoverSquadControlApp.StandardError.ReadToEnd());

			return output.Trim();
		}

		public void InputCommands(IEnumerable<string> commands)
		{
			foreach (var command in commands)
			{
				InputCommand(command);
			}
		}

		public IEnumerable<string> GetOutputAsCollection()
		{
			var output = GetOutput();
			var outputAsCollection = Regex.Split(output, "\r\n");
			return outputAsCollection;
		}
	}
}