﻿using System;
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
			Console.WriteLine(calc);
		}
	}
}
