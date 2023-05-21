using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        DataTable table = new DataTable();
        public String Result { get; set; } = "0";

        public String Operation { get; set; } = "";

        public ICommand AddButton => new Command(() => Operation += "+");
        public ICommand minusButton => new Command(() => Operation += "-");
        public ICommand multiplicationButton => new Command(() => Operation += "*");
        public ICommand fractionButton => new Command(() => Operation += "/");
        public ICommand percentButton => new Command(() => Operation += "%");
        public ICommand pointButton => new Command(() => Operation += ".");
        public ICommand zeroButton => new Command(() => Operation += "0");
        public ICommand oneButton => new Command(() => Operation += "1");
        public ICommand twoButton => new Command(() => Operation += "2");
        public ICommand threeButton => new Command(() => Operation += "3");
        public ICommand fourButton => new Command(() => Operation += "4");
        public ICommand fiveButton => new Command(() => Operation += "5");
        public ICommand sixButton => new Command(() => Operation += "6");
        public ICommand sevenButton => new Command(() => Operation += "7");
        public ICommand eigthButton => new Command(() => Operation += "8");
        public ICommand nineButton => new Command(() => Operation += "9");
        public ICommand clearButton => new Command(() => Operation = Operation.Length > 0 ? Operation.Substring(0, Operation.Length - 1) : "");
        public ICommand clearAllButton => new Command(() => { Operation = ""; Result = "0"; });

        public ICommand resultButton => new Command(() =>
        {
            try
            {
                var result = table.Compute(Operation, "");
                Result = result.ToString();
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Error", $"Error de Sintaxis\nVuelve a Intentarlo", "Ok");
                Result = "0";
            }
        });


    }
}