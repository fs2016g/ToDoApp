using System;
namespace ToDoListApp
{
	public class ToDoItem
	{
		public string TodoText { get; set; }
		public bool Complete { get; set; }

		public ToDoItem(string TodoText, bool Complete)
		{
			this.TodoText = TodoText;
			this.Complete = Complete;
		}
	}
}

