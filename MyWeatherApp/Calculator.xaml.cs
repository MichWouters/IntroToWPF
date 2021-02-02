using System.Windows;
using System.Windows.Controls;

namespace MyWeatherApp
{
    public partial class Calculator : Window
    {
        private ICalculations _calculations;

        private Operation _selectedOperator;
        private double _lastNumber, _result;

        public Calculator()
        {
            InitializeComponent();
            _calculations = new Calculations();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender is Button senderButton)
            {
                selectedValue = int.Parse(senderButton.Content.ToString());
            }

            if (LblResult.Content.ToString() == "0")
            {
                LblResult.Content = selectedValue;
            }
            else
            {
                LblResult.Content = $"{LblResult.Content}{selectedValue}";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(LblResult.Content.ToString(), out _lastNumber))
            {
                LblResult.Content = "0";
            }

            if (sender == BtnDivision)
            {
                _selectedOperator = Operation.Divide;
            }
            if (sender == BtnMultiplication)
            {
                _selectedOperator = Operation.Multiply;
            }
            if (sender == BtnPlus)
            {
                _selectedOperator = Operation.Add;
            }
            if (sender == BtnMinus)
            {
                _selectedOperator = Operation.Subtract;
            }
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;

            if (double.TryParse(LblResult.Content.ToString(), out newNumber))
            {
                switch (_selectedOperator)
                {
                    case Operation.Add:
                        _result = _calculations.Add(_lastNumber, newNumber);
                        break;

                    case Operation.Subtract:
                        _result = _calculations.Subtract(_lastNumber, newNumber);
                        break;

                    case Operation.Multiply:
                        _result = _calculations.Multiply(_lastNumber, newNumber);
                        break;

                    case Operation.Divide:
                        _result = _calculations.Divide(_lastNumber, newNumber);
                        break;
                }

                LblResult.Content = _result;
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (LblResult.Content.ToString().Contains("."))
            {
                // Do nothing
            }
            else
            {
                LblResult.Content = $"{LblResult.Content}.";
            }
        }

        private void Reset()
        {
            LblResult.Content = 0;
            _lastNumber = 0;
        }
    }

    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide,
    }
}