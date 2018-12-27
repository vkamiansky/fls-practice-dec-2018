using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TaskList.Interface;
using TaskList.Model;

namespace TaskList.ViewModel
{
    public class TestNewTaskViewModel : INotifyPropertyChanged, INewTaskViewModel
    {           
        public event PropertyChangedEventHandler PropertyChanged;

        private string name = "New task";

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string description = "wegfeargaergergerkgjegfeargaergergerkgjwoerjgpaerioagegfeargaergergerkgjwoerjgpaerioagegfeargaergergerkgjwoerjgpaerioagwoerjgpaerioagjeoirgjeropigja[wthatehthsthsrthsrthsrthsrhsr";

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        private int x = 50;

        public int X
        {
            get => x;
            set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }

        private int y = 62;

        public int Y
        {
            get => y;
            set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }


        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}