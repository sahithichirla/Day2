using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ArithmeticOperations
{
    public class CalViewModel : INotifyPropertyChanged
    {
        public CalViewModel()
        {
            AddCommand = new Command(() =>
            {
                Result = Add().ToString();
            });

            SubtractCommand = new Command(() =>
            {
                Result = Subtract().ToString();
            });

            MultiplyCommand = new Command(() =>
            {
                Result = Multiply().ToString();
            });

            DivideCommand = new Command(() =>
            {
                Result = Divide().ToString();
            });
        }

        int _num1;
        int _num2;
        string _result;

        public int Num1
        {
            get => _num1;
            set
            {
                _num1 = value;
                OnPropertyChanged(nameof(Num1));
            }
        }

        public int Num2
        {
            get => _num2;
            set
            {
                _num2 = value;
                OnPropertyChanged(nameof(Num2));
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            if (Num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return (double)Num1 / Num2;
        }

        public Command AddCommand { get; }
        public Command SubtractCommand { get; }
        public Command MultiplyCommand { get; }
        public Command DivideCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
