namespace MarsRover
{
	public class Rover
	{		
		public Rover(Position startingPosition, IOutput output)
		{
			
			CurrentPosition = startingPosition;
		}

		public Position CurrentPosition { get; private set; }

		public void Move(Instruction instruction)
		{
			
		}
	}
}