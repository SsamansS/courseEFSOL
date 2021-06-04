using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using basic_lesson12_solution4.Model;
using basic_lesson12_solution4.View;

namespace basic_lesson12_solution4.Presenter
{
    public class OperationsPresenter
    {
        IOperations operationsView;
        
        public OperationsPresenter(IOperations view)
        {
            operationsView = view;
        }
        public void Plus()
        {
            Operations operations = new Operations();
            operations.Number1 = double.Parse(operationsView.Num1Text);
            operations.Number2 = double.Parse(operationsView.Num2Text);

            operationsView.ResultText = operations.Plus().ToString();
        }
        public void Minus()
        {
            Operations operations = new Operations();
            operations.Number1 = double.Parse(operationsView.Num1Text);
            operations.Number2 = double.Parse(operationsView.Num2Text);

            operationsView.ResultText = operations.Minus().ToString();
        }
        public void Mult()
        {
            Operations operations = new Operations();
            operations.Number1 = double.Parse(operationsView.Num1Text);
            operations.Number2 = double.Parse(operationsView.Num2Text);

            operationsView.ResultText = operations.Mult().ToString();
        }
        public void Div()
        {
            Operations operations = new Operations();
            operations.Number1 = double.Parse(operationsView.Num1Text);
            operations.Number2 = double.Parse(operationsView.Num2Text);

            operationsView.ResultText = operations.Div().ToString();
        }
    }
}
