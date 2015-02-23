using System;

namespace TaskManager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TaskManager Manger = new TaskManager ();

			bool checkMe = true;
			int switchMe;

			while (checkMe) {
				Console.WriteLine ("MENU:");
				Console.WriteLine ("----------------");
				Console.WriteLine ("1. Add new task");
				Console.WriteLine ("2. Get task by ID");
				Console.WriteLine ("3. Check tasks");
				Console.WriteLine ("4. Quit");

				switchMe = int.Parse(Console.ReadLine ());

				switch (SwitchMe) {
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				default:
					Console.WriteLine ("The number you have entered, doesn't match any options. Please try again.");
					break;
				}
			}
		}
	}
}
