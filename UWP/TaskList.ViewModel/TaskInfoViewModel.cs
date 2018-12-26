using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using TaskList.Model;

namespace TaskList.ViewModel
{
    public class TaskInfoViewModel : INotifyPropertyChanged
    {
        private TaskModel task;

        /// <summary>
        /// Заголовок Задания
        /// </summary>
        public string Title
        {
            get => task.Title;
            set
            {
                task.Title = value;
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Текст описания задания
        /// </summary>
        public string Description
        {
            get => task.Description;
            set
            {
                task.Description = value;
                OnPropertyChanged("Description");
            }
        }

        public TaskInfoViewModel(string title, string description)
        {
            task = new TaskModel();
            this.Title = title;
            this.Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
