using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Core.Calculators;
using WpfApp3.ViewModels.Base;

namespace WpfApp3.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {

        private bool hasCalculated;

        public readonly ICalculator calculator;

        public ShellViewModel(ICalculator calculator)
        {
           this.calculator = calculator;
        }

        public string Title { get; } = "КалькуЛятаp";

        private string calculatorText;

        public string CalculatorText
        {
            get { return calculatorText; }
            set { SetProperty(ref calculatorText, value); }
        }




        public DelegateCommand<object> AddNumberCommand {get; set;}

        public DelegateCommand DeleteCommand { get; set; }

        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
            DeleteCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void Calculate()
        {
            CalculatorText = calculator.Calculate(CalculatorText).ToString("N2");
            hasCalculated = true;
        }

        private void Clear()
        {
            CalculatorText = string.Empty;
        }


        private void AddNumber(object buttonValue)
        {
            if (hasCalculated)
            {
                Clear();
                hasCalculated = false;
            }
            CalculatorText += buttonValue.ToString();
        }


    }
}
