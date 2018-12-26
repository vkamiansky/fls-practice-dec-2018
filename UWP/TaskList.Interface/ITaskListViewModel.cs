using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace TaskList.Interface
{
    public interface ITaskListViewModel
    {
        ObservableCollection<ITaskInfoViewModel> Task { get; set; }
        ICommand AddNewTaskCommand { get; set; }
        ICommand EditTaskCommand { get; set; }
    }
}
