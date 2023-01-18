using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    internal class Calculator
    {
        private double FirstNumber;
        private double SecondNumber;

        private char _action;

        public double Calculate(string LabelText)
        {
            if (LabelText.Split('\n').Length != 2)
                throw new ArgumentException("Wrong String");
            SecondNumber = Convert.ToDouble(LabelText.Split('\n').Last());
            return _action switch
            {
                '+' => Convert.ToDouble(FirstNumber + SecondNumber),
                '÷' => Convert.ToDouble(FirstNumber / SecondNumber),
                '×' => Convert.ToDouble(FirstNumber * SecondNumber),
                '-' => Convert.ToDouble(FirstNumber - SecondNumber),
                _ => throw new NotImplementedException("This action was not implemented")
            };
        }

        public void ActionPressed(string LabelText, string action)
        {
            _action = Convert.ToChar(action);
            FirstNumber = Convert.ToDouble(LabelText.Split('\n').First());
        }
    }
}
