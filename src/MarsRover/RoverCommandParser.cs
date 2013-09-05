using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
	public class RoverCommandParser
	{
		public static IEnumerable<RobotCommand> Parse(IEnumerable<string> inputCommands)
		{
			var roverCommands = inputCommands.Skip(1).ToList();
			for (int i = 0; i < roverCommands.Count(); i += 2)
			{
				yield return new RobotCommand
					{
						StartingPosition = Position.Parse(roverCommands[i]),
						Instructions = ParseInstructions.From(roverCommands[i+1])
					};
			}
		}
		
	}
}