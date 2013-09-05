using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.SquadControlApp
{
	class Program
	{
		

		static void Main(string[] args)
		{
			var marsRoverSquadControl = new MarsRoverSquadControl(new ConsoleOutput(false));
			marsRoverSquadControl.SendCommand(FromConsoleInput().ToList());
		}

		private static IEnumerable<string> FromConsoleInput()
		{
			string line;
			while ("GO" != (line = Console.ReadLine()))
			{
				yield return line;
			}
		}
	}
}
