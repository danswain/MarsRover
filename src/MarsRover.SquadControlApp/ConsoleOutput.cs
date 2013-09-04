using System;

namespace MarsRover.SquadControlApp
{
	public class ConsoleOutput : IOutput
	{
		public void WriteLine(string line)
		{
			Console.WriteLine(line);
		}
	}
}