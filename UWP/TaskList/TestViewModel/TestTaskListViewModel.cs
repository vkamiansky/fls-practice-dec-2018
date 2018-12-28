using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TaskList.Interface;
using TaskList.ViewModel;
using System.Drawing;

namespace TaskList.TestViewModel
{
    public class TestTaskListViewModel : INotifyPropertyChanged, ITaskListViewModel
    {
        private const string SOMETEXT = "Lorem ipsum dolor sit amet, consectetur " +
            "adipiscing elit. Duis gravida nisl sed egestas placerat. Aenean mattis " +
            "imperdiet lacus. Morbi iaculis urna id ex dapibus pretium.";

        public ObservableCollection<ITaskInfoViewModel> Tasks
        {
            get => new ObservableCollection<ITaskInfoViewModel>
            {
                new TaskInfoViewModel("Первый заголовок",SOMETEXT, "Важно", Color.Black,
                    ImpKey.Important, UrgKey.Urgent),
                new TaskInfoViewModel("Второй заголовок",SOMETEXT, "Важно", Color.Red, 
                    ImpKey.Unimportant, UrgKey.Nonurgent),
                new TaskInfoViewModel("Третий заголовок",SOMETEXT, "Очень важно", Color.Yellow,
                    ImpKey.Unimportant, UrgKey.Nonurgent),
                new TaskInfoViewModel("Четвертый заголовок",SOMETEXT, "Важно", Color.Red,
                    ImpKey.Unimportant, UrgKey.Nonurgent),
                new TaskInfoViewModel("Пятый заголовок",SOMETEXT, "Очень важно", Color.Blue,
                    ImpKey.Important, UrgKey.Nonurgent)
            };
            set { }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private ITaskInfoViewModel selectedTask;

        public INavigationService NavigationService { get; set; }

        public ITaskInfoViewModel SelectedTask
        {
            get => Tasks[0];
            set
            {
                selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public ICommand BackCommand { get; set; }

        public TestTaskListViewModel()
        {
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}