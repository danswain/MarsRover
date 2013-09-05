namespace MarsRover.Interfaces
{
	public interface ICanNavigate
	{
		void RoteRightFrom(Position currentPosition);
		void RotateLeftFrom(Position currentPosition);
		void MoveFrom(Position currentPosition);
	}
}