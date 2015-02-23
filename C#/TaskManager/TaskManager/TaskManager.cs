using System;
using System.Collections.Generic;

namespace TaskManager
{
	public class TaskManager
	{
		public Dictionary<int, Task> tasks = new Dictionary<int, Task>();

		public Dictionary<int, Task> GetTasksById(int id){
			Dictionary<int, Task> returnMe = new Dictionary<int, Task> ();

			foreach (var item in tasks) {
				if (item.Value.Id == id) {
					returnMe.Add (item.Value.Id, item.Value);
				}
			}

			return returnMe;
		}

		public TaskManager ()
		{
		}
	}
}

