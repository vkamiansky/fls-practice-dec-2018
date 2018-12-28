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
        private string degreeОfImportance;

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

        /// <summary>
        /// Степень важности
        /// </summary>
        public string DegreeОfImportance {
            get => degreeОfImportance;
            set
            {
                this.degreeОfImportance = value;
                OnPropertyChanged("DegreeОfImportance");
            }
        }

        public TaskInfoViewModel(string title, string description, string degreeОfImportance)
        {
            task = new TaskModel();
            this.Title = title;
            this.Description = description;
            this.DegreeОfImportance = degreeОfImportance;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
