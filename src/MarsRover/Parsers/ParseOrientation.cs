﻿using System;

namespace MarsRover.Parsers
{
	public class ParseOrientation
	{
		public static Orientation From(string input)
		{
			return (Orientation) Enum.Parse(typeof(Orientation), input);
		}
	}
}