using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DialogHostTest
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool _isOpen;
        private ViewModel1 _actualViewModel;

        public MainWindowViewModel()
        {
            //IsOpen = true;
            ActualViewModel = new ViewModel1();
            IsOpen = true;
        }

        public ViewModel1 ActualViewModel
        {
            get { return _actualViewModel; }
            set
            {
                if (_actualViewModel != value)
                {
                    _actualViewModel = value;
                    NotifyPropertyChanged("ActualViewModel");
                }
            }
        }
        public bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                if (_isOpen != value)
                {
                    _isOpen = value;
                    NotifyPropertyChanged("IsOpen");
                }
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
