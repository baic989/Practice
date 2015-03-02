using System;
using System.Collections.Generic;

namespace TaskManager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TaskManager Manager = new TaskManager ();
			Manager.eventAlert += Alert;

			bool checkMe = true;

			try {
				while (checkMe) {
					Console.WriteLine ("MENU:");
					Console.WriteLine ("----------------");
					Console.WriteLine ("1. Add new task");
					Console.WriteLine ("2. Get task by ID");
					Console.WriteLine ("3. Get task by category");
					Console.WriteLine ("4. Check tasks");
					Console.WriteLine ("5. Quit");
				
					int switchMe = int.Parse (Console.ReadLine ());
				
					switch (switchMe) {
					case 1:
						Console.WriteLine ("Enter name of new task:");
						string taskName = Console.ReadLine ();
						Console.WriteLine ("Enter task category:");
						string taskCategory = Console.ReadLine ();
						Console.WriteLine ("Enter task date and time of execution in format " + DateTime.Now.Date);
						DateTime taskDate = DateTime.Parse(Console.ReadLine());
				
						Task t = new Task (taskName, taskCategory, taskDate);
						Manager.tasks.Add (t.Id, t);
						break;
					case 2:
						List<Task> tasksById = new List<Task> ();
				
						Console.WriteLine ("Please enter task ID:");
						int taskID = int.Parse (Console.ReadLine ());
				
						tasksById = Manager.GetTasksById (taskID);
				
						if (tasksById.Count != 0) {
							foreach (var item in tasksById) {
								Console.WriteLine (item);
							}
						} else {
							Console.WriteLine ("There are no entries found for that ID.");
						}

						break;
					case 3:
						List<Task> tasksByCategory = new List<Task>();

						Console.WriteLine ("Please enter task category:");
						string category = Console.ReadLine();

						tasksByCategory = Manager.GetTaskByCategory(category);

						if(tasksByCategory.Count != 0){
							foreach(var item in tasksByCategory){
								Console.WriteLine (item);
							}
						}
						else{
							Console.WriteLine ("There are no entries found for that category.");
						}

						break;
					case 4:
						Console.WriteLine ("Tasks within 15 minutes:");
						Console.WriteLine ("------------------------");
						Manager.CheckTasks();
						break;
					case 5:
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

		public static void Alert(Task sender, EventArgs e){
			Console.WriteLine ("Task " + sender.Name + " ending in " + ((sender.ExecTime.Minute) - DateTime.Now.Minute) + "minute(s).");
		}
	}
}
