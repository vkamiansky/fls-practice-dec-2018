using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Control.ViewModel
{
    public class TestViewModel:INotifyPropertyChanged
    {
        private double _x;
        private double _y;
        private string _x_title;
        private string _y_title;
        public double X {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }
        public string Y_Title {
            get { return _y_title; }
            set
            {
                _y_title = value;
                OnPropertyChanged("Y_Title");
            }
        }
        public string X_Title {
            get { return _x_title; }
            set
            {
                _x_title = value;
                OnPropertyChanged("X_Title");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
