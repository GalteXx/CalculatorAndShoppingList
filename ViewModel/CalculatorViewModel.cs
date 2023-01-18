
using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _displayString = "0";
        public Calculator calculator = new();
        public ICommand DigitPressed => new Command<string>(NewDigit);
        public ICommand ActionPressed => new Command<string>(NewAction);
        public ICommand EqualsPressed => new Command(EqPressed);
        public ICommand ResetPressed => new Command(ResetClicked);

        public string DisplayString { 
            
            get => _displayString; 
            set
            {
                _displayString = value;
                OnPropertyChanged();
            }
        }

        private void NewDigit(string digitName)
        {
            DisplayString += digitName;
        }

        private void NewAction(string action)
        {
            DisplayString += '\n';
            try
            {
                calculator.ActionPressed(_displayString, action);
            }
            catch(Exception e)
            {

            }
        }

        private void ResetClicked()
        {
            DisplayString = "0";
        }

        private void EqPressed()
        {
            try
            {
               DisplayString = calculator.Calculate(_displayString).ToString();
            }
            catch(Exception e)
            {

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
