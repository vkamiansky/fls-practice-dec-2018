using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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

        public INavigationService NavigationService { get; set; }

        public TaskInfoViewModel SelectedTask
        {
            get => selectedTask;
            set
            {
                selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public ICommand BackCommand { get; private set; }

        public TestTaskListViewModel()
        {
            this.Tasks = new ObservableCollection<TaskInfoViewModel>
            {
                new TaskInfoViewModel("Первый заголовок",SOMETEXT, "Важно"),
                new TaskInfoViewModel("Второй заголовок",SOMETEXT, "Важно"),
                new TaskInfoViewModel("Третий заголовок",SOMETEXT, "Очень важно"),
                new TaskInfoViewModel("Четвертый заголовок",SOMETEXT, "Важно"),
                new TaskInfoViewModel("Пятый заголовок",SOMETEXT, "Очень важно")
            };
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}