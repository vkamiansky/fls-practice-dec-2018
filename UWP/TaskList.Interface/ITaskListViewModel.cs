using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace TaskList.Interface
{
    public interface ITaskListViewModel : IViewModel
    {
        ObservableCollection<ITaskInfoViewModel> Tasks { get; set; }

        INavigationService NavigationService { get; set; }

        ITaskInfoViewModel SelectedTask { get; set; }

        ICommand BackCommand { get;  set; }
    }
}
