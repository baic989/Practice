using System;

namespace TaskManager
{
	public class Task
	{
		private static int _id = 0;
		private readonly int id;

		public int Id {
			get {
				return id;
			}
		}

		public string Name {
			get;
			set;
		}

		public string Category {
			get;
			set;
		}

		public Task (string name, string category)
		{
			this.Name = name;
			this.Category = category;

			id = _id++;
		}

		public override string ToString ()
		{
			return string.Format ("Task: [Id={0}, Name={1}, Category={2}]", Id, Name, Category);
		}
	}
}

