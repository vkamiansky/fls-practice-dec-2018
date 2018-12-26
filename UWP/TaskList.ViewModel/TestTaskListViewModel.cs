using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TaskList.Interface;
using TaskList.Model;

namespace TaskList.ViewModel
{
    public class TestTaskListViewModel : INotifyPropertyChanged, ITestTaskListViewModel
    {
        private const string SOMETEXT = "Lorem ipsum dolor sit amet, consectetur " +
            "adipiscing elit. Duis gravida nisl sed egestas placerat. Aenean mattis " +
            "imperdiet lacus. Morbi iaculis urna id ex dapibus pretium.";

        public ObservableCollection<TaskModel> Tasks { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private TaskModel selectedTask;

        public TaskModel SelectedTask
        {
            get => selectedTask;
            set
            {
                selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public TestTaskListViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>
            {
                new TaskModel("Первый заголовок",SOMETEXT),
                new TaskModel("Второй заголовок",SOMETEXT),
                new TaskModel("Третий заголовок",SOMETEXT)
            };
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}