using System;
using System.Text.RegularExpressions;

namespace MarsRover
{
	public class Coordinate : IEquatable<Coordinate>
	{
		public static Coordinate Parse(string input)
		{
			if (!Regex.IsMatch(input, @"^\d \d$"))
				throw new InputBoundaryException(input + " is not a valid coordinate");

			var inputArray = input.Split(' ');

			return new Coordinate
				{
					X = int.Parse(inputArray[0]),
					Y = int.Parse(inputArray[1])
				};
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Y*397) ^ X;
			}
		}

		public static bool operator ==(Coordinate left, Coordinate right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Coordinate left, Coordinate right)
		{
			return !Equals(left, right);
		}

		public Coordinate(int x = 0, int y = 0)
		{
			X = x;
			Y = y;
		}

		public int Y { get; set; }

		public int X { get; set; }

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Coordinate) obj);
		}

		public bool Equals(Coordinate obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Y == obj.Y && X == obj.X;
		}
	}
}