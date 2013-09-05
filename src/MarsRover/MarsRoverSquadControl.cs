using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
	public class MarsRoverSquadControl
	{
		private readonly IOutput _output;
		private List<Rover> _rovers = new List<Rover>();
		private ICanNavigate _navigationSystem;

		public MarsRoverSquadControl(IOutput output)
		{
			_output = output;
			_navigationSystem = new NavigationSystem();
		}

		public void SendCommand(IEnumerable<string> input)
		{
			var lowerLeftCoordinatesOfPlateau = new Coordinate(0, 0);
			var upperRightCoordinatesOfPlateau = ParseCoordinate.From(input.First());

			var roverCommands = ParseRoverCommands.From(input);

			foreach (var roverCommand in roverCommands)
			{
				var rover = new Rover(roverCommand.StartingPosition, _output, _navigationSystem);
				foreach (var instruction in roverCommand.Instructions)
				{
					rover.Send(instruction);
				}
				_rovers.Add(rover);
				_output.Write(rover.CurrentPosition.ToString());
			}			
		}
	}
}