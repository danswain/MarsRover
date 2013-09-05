using System.Collections.Generic;

namespace MarsRover
{
	public class RobotCommand
	{
		public Position StartingPosition { get; set; }

		public IEnumerable<Instruction> Instructions { get; set; }
	}
}