using Prism.Commands;
using test1.Core.test;
using WpfApp3.Core.Calculators;
using WpfApp3.ViewModels.Base;

namespace WpfApp3.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        #region Fields
        private bool hasCalculated;
        private string calculatorText;
        public readonly ICalculator _calculator;
        public readonly ITest _test;
        private bool _isEnabled;
        #endregion

        #region Constructor
        public ShellViewModel(ICalculator calculator, ITest test)
        {
            _calculator = calculator;
            _test = test;
        }
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                SetProperty(ref _isEnabled, value);
                ClearCommand.RaiseCanExecuteChanged();
            }
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

        #endregion

        #region Methods
        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
            DeleteCommand = new DelegateCommand(Delete);
            EqualsCommand = new DelegateCommand(Calculate);
            ClearCommand = new DelegateCommand(Clear).ObservesCanExecute(() => IsEnabled);
        }

        private void Clear()
        {
            if (CalculatorText != string.Empty)
                CalculatorText = _test.CharClear(CalculatorText).ToString();
            if (CalculatorText == string.Empty)
                IsEnabled = false;
        }

        private void Calculate()
        {

            CalculatorText = _calculator.Calculate(CalculatorText).ToString("N2");
            hasCalculated = true;
        }

        private void Delete()
        {
            CalculatorText = string.Empty;
            IsEnabled = false;
        }

        private void AddNumber(object buttonValue)
        {
            IsEnabled = true;
            if (hasCalculated)
            {
                Delete();
                hasCalculated = false;
            }
            CalculatorText += buttonValue.ToString();

        } 
        #endregion
    }
}
