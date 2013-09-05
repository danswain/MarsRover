using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
	public class MarsRoverSquadControl
	{
		private readonly IOutput _output;
		private List<Rover> _rovers = new List<Rover>();

		public MarsRoverSquadControl(IOutput output)
		{
			_output = output;
		}

		public void SendCommand(IEnumerable<string> input)
		{
			var lowerLeftCoordinatesOfPlateau = new Coordinate(0, 0);
			var upperRightCoordinatesOfPlateau = Coordinate.Parse(input.First());

			var roverCommands = RoverCommandParser.Parse(input);

			foreach (var roverCommand in roverCommands)
			{
				var rover = new Rover(roverCommand.StartingPosition, _output);
				foreach (var instruction in roverCommand.Instructions)
				{
					rover.Move(instruction);
				}
				_rovers.Add(rover);
				_output.WriteLine(rover.CurrentPosition.ToString());
			}			
		}
	}
}