﻿using System.Collections.ObjectModel;
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

        public ObservableCollection<ITaskInfoViewModel> Tasks { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private ITaskInfoViewModel selectedTask;

        public INavigationService NavigationService { get; set; }

        public ITaskInfoViewModel SelectedTask
        {
            get => selectedTask;
            set
            {
                selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public ICommand BackCommand { get; set; }

        public TestTaskListViewModel()
        {
            this.Tasks = new ObservableCollection<ITaskInfoViewModel>
            {
                new TaskInfoViewModel("Первый заголовок",SOMETEXT, "Важно", Color.Black),
                new TaskInfoViewModel("Второй заголовок",SOMETEXT, "Важно", Color.Red),
                new TaskInfoViewModel("Третий заголовок",SOMETEXT, "Очень важно", Color.Yellow),
                new TaskInfoViewModel("Четвертый заголовок",SOMETEXT, "Важно", Color.Red),
                new TaskInfoViewModel("Пятый заголовок",SOMETEXT, "Очень важно", Color.Blue )
            };
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}