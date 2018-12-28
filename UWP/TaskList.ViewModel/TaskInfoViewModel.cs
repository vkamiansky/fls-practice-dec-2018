using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using TaskList.Interface;

using TaskList.Model;

namespace TaskList.ViewModel
{
    public class TaskInfoViewModel : INotifyPropertyChanged, ITaskInfoViewModel
    {
        private TaskModel task;
        private Color color;

        private string degreeОfImportance;
        /// <summary>
        /// Id Задания
        /// </summary>
        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Заголовок Задания
        /// </summary>
        public string Name
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

        public double UrgencyMeasureY { get; set; }
        public double ImportanceMeasureX { get ; set ; }

        public Color TaskColor
        {
            get => color;
            set
            {
                this.color = value;
                OnPropertyChanged("TaskColor");
            }
        }

        public ImpKey Importance { get; set; }
        public UrgKey Urgency { get; set; }

        public TaskInfoViewModel() { }

        public TaskInfoViewModel(string title, string description, 
            string degreeОfImportance, Color taskColor,
            ImpKey impKey, UrgKey urgKey)
        {
            task = new TaskModel();
            this.Name = title;
            this.Description = description;
            this.DegreeОfImportance = degreeОfImportance;
            this.TaskColor = taskColor;
            this.Importance = impKey;
            this.Urgency = urgKey;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
