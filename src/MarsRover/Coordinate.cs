using System.Text.RegularExpressions;

namespace MarsRover
{
	public class Coordinate
	{
		public static Coordinate Parse(string input)
		{
			if (!Regex.IsMatch(input, @"^\d \d$"))
				throw new InputBoundaryException(input + " is not a valid coordinate");

			var inputArray = input.Split(' ');
			return new Coordinate
				{
					X = int.Parse(inputArray[0]),
					Y = int.Parse(inputArray[1])
				};
		}

		public int Y { get; set; }

		public int X { get; set; }
	}
}