using Prism.Commands;
using test1.Core.test;
using WpfApp3.Core.Calculators;
using WpfApp3.ViewModels.Base;

namespace WpfApp3.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {

        private bool hasCalculated;
        private string calculatorText;
        public readonly ICalculator _calculator;
        public readonly ITest _test;
        private bool status;
        public ShellViewModel(ICalculator calculator, ITest test)
        {
            _calculator = calculator;
            _test = test;
        }

        public string Title { get; } = "КалькуЛятаp";

        public string CalculatorText
        {
            get { return calculatorText; }
            set { SetProperty(ref calculatorText, value); }
        }

        public DelegateCommand<object> AddNumberCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
            DeleteCommand = new DelegateCommand(Delete);
            EqualsCommand = new DelegateCommand(Calculate);
            ClearCommand = new DelegateCommand(Clear, Status);
        }

        private bool Status()
        {
            if (status)
            {
                return true;
            }
            return false;
        }

        private void Clear()
        {
            if (CalculatorText != null)
            {
                CalculatorText = _test.CharClear(CalculatorText).ToString();
            }

            if (CalculatorText == string.Empty)
            {
                status = false;
                ClearCommand.RaiseCanExecuteChanged();
            }

        }

        private void Calculate()
        {

            CalculatorText = _calculator.Calculate(CalculatorText).ToString("N2");
            hasCalculated = true;
        }

        private void Delete()
        {
            CalculatorText = string.Empty;
        }


        private void AddNumber(object buttonValue)
        {

            status = true;
            ClearCommand.RaiseCanExecuteChanged();
            if (hasCalculated)
            {
                Delete();
                hasCalculated = false;
            }
            CalculatorText += buttonValue.ToString();

        }


    }
}
