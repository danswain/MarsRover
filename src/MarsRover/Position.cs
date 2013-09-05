
using System;
using System.Text.RegularExpressions;

namespace MarsRover
{
	public class Position : IEquatable<Position>
	{
		public Orientation Orientation { get; set; }
		public Coordinate Coordinate { get; set; }

		public override int GetHashCode()
		{
			unchecked
			{
				return ((int) Orientation*397) ^ Coordinate.GetHashCode();
			}
		}

		public static bool operator ==(Position left, Position right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Position left, Position right)
		{
			return !Equals(left, right);
		}

		public static Position Parse(string input)
		{
			if(!Regex.IsMatch(input,@"^\d \d [NSEW]$"))
				throw new CouldNotParsePositionException("Could not parse position from: " + input);

			var positionArray = input.Split(' ');
			return new Position
				{
					Coordinate = Coordinate.Parse(positionArray[0] + " " + positionArray[1]),
					Orientation = ParseOrientation.From(positionArray[2])

				};
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Position) obj);
		}

		public bool Equals(Position obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Orientation == obj.Orientation && Coordinate.Equals(obj.Coordinate);
		}

		public override string ToString()
		{
			return Coordinate.X + " " + Coordinate.Y + " " + Orientation.ToString();
		}


	}

	public enum Orientation
	{
		N,S,E,W
	}
	public class ParseOrientation
	{
		public static Orientation From(string input)
		{
			return (Orientation) Enum.Parse(typeof(Orientation), input);
		}
	}
}