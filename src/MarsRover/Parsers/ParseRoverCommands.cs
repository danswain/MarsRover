using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Parsers
{
	public class ParseRoverCommands
	{
		public static IEnumerable<RobotCommand> From(IEnumerable<string> inputCommands)
		{
			var roverCommands = inputCommands.Skip(1).ToList();
			for (int i = 0; i < roverCommands.Count(); i += 2)
			{
				yield return new RobotCommand
					{
						StartingPosition = ParsePosition.From(roverCommands[i]),
						Instructions = ParseInstructions.From(roverCommands[i+1])
					};
			}
		}
		
	}
}