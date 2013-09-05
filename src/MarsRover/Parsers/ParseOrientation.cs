using System;

namespace MarsRover
{
	public class ParseOrientation
	{
		public static Orientation From(string input)
		{
			return (Orientation) Enum.Parse(typeof(Orientation), input);
		}
	}
}