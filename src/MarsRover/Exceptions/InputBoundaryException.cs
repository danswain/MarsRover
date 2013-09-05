using System;

namespace MarsRover.Exceptions
{
	public class InputBoundaryException : Exception
	{
		public InputBoundaryException(string message) : base(message){}
	}
}