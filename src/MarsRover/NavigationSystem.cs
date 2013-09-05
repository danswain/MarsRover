using MarsRover.Interfaces;

namespace MarsRover
{
	public class NavigationSystem : ICanNavigate
	{
		
		public void RoteRightFrom(Position currentPosition)
		{
			switch (currentPosition.Orientation)
			{
				case Orientation.N:
					currentPosition.Orientation = Orientation.E;
					break;
				case Orientation.W:
					currentPosition.Orientation = Orientation.N;
					break;
				case Orientation.S:
					currentPosition.Orientation = Orientation.W;
					break;
				case Orientation.E:
					currentPosition.Orientation = Orientation.S;
					break;
			}
		}

		public void RotateLeftFrom(Position currentPosition)
		{
			switch (currentPosition.Orientation)
			{
				case Orientation.N:
					currentPosition.Orientation = Orientation.W;
					break;
				case Orientation.W:
					currentPosition.Orientation = Orientation.S;
					break;
				case Orientation.S:
					currentPosition.Orientation = Orientation.E;
					break;
				case Orientation.E:
					currentPosition.Orientation = Orientation.N;
					break;
			}
			
		}

		public void MoveFrom(Position currentPosition)
		{
			if (currentPosition.Orientation == Orientation.N)
				currentPosition.Coordinate.Y += 1;

			if (currentPosition.Orientation == Orientation.W)
				currentPosition.Coordinate.X -= 1;

			if (currentPosition.Orientation == Orientation.S)
				currentPosition.Coordinate.Y -= 1;

			if (currentPosition.Orientation == Orientation.E)
				currentPosition.Coordinate.X += 1;
			
		}
	}
}