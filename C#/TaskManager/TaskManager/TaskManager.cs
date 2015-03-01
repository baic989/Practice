using System;
using System.Collections.Generic;

namespace TaskManager
{
	public class TaskManager
	{
		public Dictionary<int, Task> tasks = new Dictionary<int, Task>();
		public event AlertDelegate eventAlert;

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

		public List<Task> GetTaskByCategory(string category){
			List<Task> returnMe = new List<Task> ();

			foreach (var item in tasks) {
				if (item.Value.Category == category) {
					returnMe.Add (item.Value);
				}
			}

			return returnMe;
		}

		public void CheckTasks(){
			foreach (var item in tasks) {
				if (DateTime.Now.Year == item.Value.ExecTime.Year && DateTime.Now.Month == item.Value.ExecTime.Month && DateTime.Now.Day == item.Value.ExecTime.Day && DateTime.Now.Hour == item.Value.ExecTime.Hour && (item.Value.ExecTime.Minute - DateTime.Now.Minute <= 15)) {
					eventAlert (item.Value, null);
				}
			}
		}

		public TaskManager ()
		{
		}
	}
}

