﻿﻿﻿using System;
namespace HelloGit
{
	public class Runner
	{
		public Runner()
		{
		}

		public void Run()
		{
			Console.Write("Runner");
			Console.Write("Runner 2");

			var calc = new Calculator();
			Console.WriteLine("User1 make this change.");
			Console.WriteLine("User2 make this change.");

			Console.WriteLine(calc.Add(5, 7));
			Console.WriteLine(calc.Subtract(7,5));
			Console.WriteLine("one more line");
		}
	}
}
