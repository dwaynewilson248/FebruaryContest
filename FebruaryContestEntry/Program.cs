using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';
		const int rows = 15;
		const int cols = 30;
		static void Main(string[] args)
		{
			// The solution implementation goes here
			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					Console.BackgroundColor = Console.ForegroundColor = GetColor(row, col);
					Console.Write(block);
				}
				Console.WriteLine();
			}

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}

		static ConsoleColor GetColor(int row, int col)
		{
			if ((row < 2 || row > rows - 3) || (col == 0 || col == cols - 1))
			{
				return ConsoleColor.Green;
			}

			return ConsoleColor.Yellow;
		}
	}
}
