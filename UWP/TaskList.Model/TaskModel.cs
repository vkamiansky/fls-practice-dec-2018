using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TaskList.Model
{
    public class TaskModel : INotifyPropertyChanged
    {
        private string title;
        private string description;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public TaskModel() { }

        public TaskModel(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}