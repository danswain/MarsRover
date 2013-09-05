namespace MarsRover
{
	public class Rover
	{
		private readonly IOutput _output;
		private readonly ICanNavigate _navigationSystem;


		public Rover(Position startingPosition, IOutput output, ICanNavigate navigationSystem)
		{
			_output = output;
			_navigationSystem = navigationSystem;
			CurrentPosition = startingPosition;
		}

		public Position CurrentPosition { get; private set; }

		public void Send(Instruction instruction)
		{
			switch (instruction)
			{
					case Instruction.M:
						Move();
						break;
					case Instruction.L:
						Left();
						break;
					case Instruction.R:
						Right();
						break;

			}
		}

		private void Right()
		{
			_navigationSystem.RoteRightFrom(CurrentPosition);
			_output.WriteLine(string.Format("{0}", CurrentPosition));
		}

		private void Left()
		{
			_navigationSystem.RotateLeftFrom(CurrentPosition);
			_output.WriteLine(string.Format("{0}", CurrentPosition));
		}

		private void Move()
		{
			_navigationSystem.MoveFrom(CurrentPosition);
			_output.WriteLine(string.Format("{0}", CurrentPosition));
		}
	}
}