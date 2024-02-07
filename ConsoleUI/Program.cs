using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			Console.Write("How old are you: ");
			string agetext = Console.ReadLine();

			bool isagevalid = int.TryParse(agetext, out int age);

			if ( isagevalid )
			{
				age -= 21;

				if ( age < 0 )
				{
					Console.WriteLine("You were not born yet in the year 2000!");
				}
				else
				{
					Console.WriteLine($"You were {age} years old in the year 2000.");
				}
			}
			else
			{
				Console.WriteLine("Please enter your age using digits.");
			}

			_ = Console.ReadLine();
		}
	}
}
