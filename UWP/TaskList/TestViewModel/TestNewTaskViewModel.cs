using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskList.Interface;

namespace TaskList.TestViewModel
{
    public class TestNewTaskViewModel : INotifyPropertyChanged, INewTaskViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _UrgencyMeasure;
        private double _ImportanceMeasure;
        private string _newTaskName;
        private string _newTaskDescription;

        public INavigationService NavigationService { get; set; }

        public ICommand CreateTaskCommand { get; set; }

        public double UrgencyMeasure
        {
            get { return _UrgencyMeasure; }
            set
            {
                _UrgencyMeasure = value;
                OnPropertyChanged("UrgencyMeasure");
            }
        }
        public double ImportanceMeasure
        {
            get { return _ImportanceMeasure; }
            set
            {
                _ImportanceMeasure = value;
                OnPropertyChanged("ImportanceMeasure");
            }
        }

        public string NewTaskName
        {
            get
            {
                return _newTaskName;
            }
            set
            {
                _newTaskName = value;
                OnPropertyChanged("NewTaskName");
            }
        }
        public string NewTaskDescription
        {
            get
            {
                return _newTaskDescription;
            }
            set
            {
                _newTaskDescription = value;
                OnPropertyChanged("NewTaskDescription");
            }
        }

        public TestNewTaskViewModel()
        {

        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
