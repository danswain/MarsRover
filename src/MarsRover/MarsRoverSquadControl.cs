using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
	public class MarsRoverSquadControl
	{
		private readonly IOutput _output;
		private List<Rover> _rovers = new List<Rover>();
		private Rover _rover;
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
				Position startingPosition = roverCommand.StartingPosition;
				_navigationSystem = new NavigationSystem();
				_rover = new Rover(startingPosition, _output, _navigationSystem);
				var rover = _rover;
				foreach (var instruction in roverCommand.Instructions)
				{
					rover.Send(instruction);
				}
				_rovers.Add(rover);
				_output.WriteLine(rover.CurrentPosition.ToString());
			}			
		}
	}
}