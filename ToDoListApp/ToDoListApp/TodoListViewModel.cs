using System;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace ToDoListApp
{
	public class TodoListViewModel
	{
		public ObservableCollection<ToDoItem> TodoItems { get; set; }

		public TodoListViewModel()
		{
			TodoItems = new ObservableCollection<ToDoItem>();

			TodoItems.Add(new ToDoItem("todo 1", false));
			TodoItems.Add(new ToDoItem("todo 2", false));
			TodoItems.Add(new ToDoItem("todo 3", false));

		}

		public ICommand AddTodoCommand => new Command(AddTodoItem);
		public string NewTodoInputValue { get; set; }
		void AddTodoItem()
		{
			TodoItems.Add(new ToDoItem(NewTodoInputValue, false));
		}
	}
}

