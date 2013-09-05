using System;

namespace MarsRover.Exceptions
{
	public class CouldNotParsePositionException : Exception
	{
		public CouldNotParsePositionException(string message) : base(message){}
	}
}