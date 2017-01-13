using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsCustomRenderer
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _isChecked1 = false;
        private bool _isReadOnly1 = false;
        private bool _isChecked2 = false;
        private bool _isReadOnly2 = true;

        public bool IsChecked1
        {
            get { return _isChecked1; }
            set
            {
                _isChecked1 = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("IsChecked1"));
            }
        }
        public bool IsReadOnly1
        {
            get { return _isReadOnly1; }
            set
            {
                _isReadOnly1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsReadOnly1"));
            }
        }

        public bool IsChecked2
        {
            get { return _isChecked1; }
            set
            {
                _isChecked1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsChecked2"));
            }
        }
        public bool IsReadOnly2
        {
            get { return _isReadOnly2; }
            set
            {
                _isReadOnly2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsReadOnly2"));
            }
        }

        private ICommand _onCheckBoxTapped1;
        public ICommand OnCheckBoxTapped1 => _onCheckBoxTapped1 ?? (_onCheckBoxTapped1 = new Command(InvokeCheckBoxTapped1));

        private void InvokeCheckBoxTapped1()
        {
            IsChecked1 = !IsChecked1;
        }

        private ICommand _onCheckBoxTapped2;
        public ICommand OnCheckBoxTapped2 => _onCheckBoxTapped2 ?? (_onCheckBoxTapped2 = new Command(InvokeCheckBoxTapped2));

        private void InvokeCheckBoxTapped2()
        {
            IsChecked2 = !IsChecked2;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
