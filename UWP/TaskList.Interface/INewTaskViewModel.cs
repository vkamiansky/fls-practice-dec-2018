using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TaskList.Interface
{
    public interface INewTaskViewModel
    {
        INavigationService NavigationService { get; set; }

        ICommand CreateTaskCommand { get; set; }

        double UrgencyMeasure { get; set; }
        double ImportanceMeasure { get; set; }
        string NewTaskName { get; set; }
        string NewTaskDescription { get; set; }

    }
}
