using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TaskList.Interface;
using TaskList.ViewModel;

namespace TaskList.TestViewModel
{
    public class TestTaskListViewModel : INotifyPropertyChanged, ITaskListViewModel
    {
        private const string SOMETEXT = "Lorem ipsum dolor sit amet, consectetur " +
            "adipiscing elit. Duis gravida nisl sed egestas placerat. Aenean mattis " +
            "imperdiet lacus. Morbi iaculis urna id ex dapibus pretium.";

        public ObservableCollection<TaskInfoViewModel> Tasks { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private TaskInfoViewModel selectedTask;

        public TaskInfoViewModel SelectedTask
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
            Tasks = new ObservableCollection<TaskInfoViewModel>
            {
                new TaskInfoViewModel("Первый заголовок",SOMETEXT),
                new TaskInfoViewModel("Второй заголовок",SOMETEXT),
                new TaskInfoViewModel("Третий заголовок",SOMETEXT)
            };
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}