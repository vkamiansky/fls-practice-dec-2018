using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskList.Interface;

namespace TaskList.TestViewModel
{
    public class TestNewTaskViewModel : INotifyPropertyChanged, ITaskListViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _x;
        private double _y;
        private string _newTaskName;
        private string _newTaskDescription;

        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
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
