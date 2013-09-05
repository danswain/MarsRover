using System;

namespace MarsRover
{
	public class CouldNotParsePositionException : Exception
	{
		public CouldNotParsePositionException(string message) : base(message){}
	}
}