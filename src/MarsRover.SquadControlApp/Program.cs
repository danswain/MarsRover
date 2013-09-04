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
			var marsRoverSquadControl = new MarsRoverSquadControl(new ConsoleOutput());

			marsRoverSquadControl.SendCommand(FromConsoleInput());
		}

		private static IEnumerable<string> FromConsoleInput()
		{
			var exitApp = false;
			while (!exitApp)
			{
				var input = Console.ReadLine();
				if (input == "GO")
					exitApp = true;
				yield return input;
			}
		}
	}
}
