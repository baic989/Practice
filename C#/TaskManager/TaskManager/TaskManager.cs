using System;
using System.Collections.Generic;

namespace TaskManager
{
	public class TaskManager
	{
		public Dictionary<int, Task> tasks = new Dictionary<int, Task>();

		public List<Task> GetTasksById(int id){
			List<Task> returnMe = new List<Task> ();

			foreach (var item in tasks) {
				if (item.Value.Id == id) {
					returnMe.Add (item.Value);
				}
			}

			return returnMe;
		}

		public List<Task> GetTasksByName(string name){
			List<Task> returnMe = new List<Task> ();

			foreach (var item in tasks) {
				if (item.Value.Name == name) {
					returnMe.Add (item.Value);
				}
			}

			return returnMe;
		}

		public TaskManager ()
		{
		}
	}
}

