using System;
using System.Data;

namespace WpfApp3.Core.Calculators
{
    public class ExpressionCalculator : ICalculator
    {
        public double Calculate(string expressoin)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expressoin, "");
            return Convert.ToDouble(value);
        }
    }
}

