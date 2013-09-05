using System;

namespace MarsRover
{
	public class InputBoundaryException : Exception
	{
		public InputBoundaryException(string message) : base(message){}
	}
}