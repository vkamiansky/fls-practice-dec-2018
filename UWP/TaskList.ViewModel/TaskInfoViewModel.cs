using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskList.Interface;

namespace TaskList.ViewModel
{
    public class TaskInfoViewModel : ITaskInfoViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _id;
        private string _name;
        private double _urgencyMeasure;
        private double _importanceMeasure;
        private string _description;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public double UrgencyMeasure
        {
            get { return _urgencyMeasure; }
            set
            {
                _urgencyMeasure = value;
                OnPropertyChanged("UrgencyMeasure");
            }
        }
        public double ImportanceMeasure
        {
            get { return _importanceMeasure; }
            set
            {
                _importanceMeasure = value;
                OnPropertyChanged("ImportanceMeasure");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");

            }
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
