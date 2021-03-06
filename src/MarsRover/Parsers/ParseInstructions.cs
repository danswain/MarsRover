﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Parsers
{
	public class ParseInstructions
	{
		public static IEnumerable<Instruction> From(string instruction)
		{
			return instruction.Select(character => (Instruction) Enum.Parse(typeof (Instruction),character.ToString()));
		}
	}
}