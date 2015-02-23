using System;
using System.Collections.Generic;

namespace TaskManager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TaskManager Manager = new TaskManager ();

			bool checkMe = true;

			try {
				while (checkMe) {
					Console.WriteLine ("MENU:");
					Console.WriteLine ("----------------");
					Console.WriteLine ("1. Add new task");
					Console.WriteLine ("2. Get task by ID");
					Console.WriteLine ("3. Check tasks");
					Console.WriteLine ("4. Quit");
				
					int switchMe = int.Parse (Console.ReadLine ());
				
					switch (switchMe) {
					case 1:
						Console.WriteLine ("Enter name of new task:");
						string taskName = Console.ReadLine ();
						Console.WriteLine ("Enter task category:");
						string taskCategory = Console.ReadLine ();
				
						Task t = new Task (taskName, taskCategory);
						Manager.tasks.Add (t.Id, t);
						break;
					case 2:
						Dictionary<int, Task> tasksByIdDict = new Dictionary<int, Task> ();
				
						Console.WriteLine ("Please enter task ID:");
						int taskID = int.Parse (Console.ReadLine ());
				
						tasksByIdDict = Manager.GetTasksById (taskID);
				
						if (tasksByIdDict.Count != 0) {
							foreach (var item in tasksByIdDict) {
								Console.WriteLine ("Item found - " + item.Value);
							}
						} else {
							Console.WriteLine ("There are no entries found for that ID.");
						}
						break;
					case 3:
				
						break;
					case 4:
						checkMe = false;
						break;
					default:
						Console.WriteLine ("The number you have entered, doesn't match any options. Please try again.");
						break;
					}
				}
			} catch (Exception ex) {
				Console.WriteLine (ex);
			}
		}
	}
}
