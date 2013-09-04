using System.Collections.Generic;

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
			foreach (var item in input)
			{
				_output.WriteLine(item);
			}
			
		}
	}
}