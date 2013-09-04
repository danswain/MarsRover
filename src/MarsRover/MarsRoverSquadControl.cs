using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarsRover
{
	public class MarsRoverSquadControl
	{
		private readonly IOutput _output;

		public MarsRoverSquadControl(IOutput output)
		{
			_output = output;
		}

		public void SendCommand(IEnumerable<string> input)
		{
			var upperRightCoordinatesOfPlateau = Coordinate.Parse(input.First());
			foreach (var item in input)
			{
				_output.WriteLine(item);
			}
			
		}
	}
}