using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using basic_lesson12_solution4.Presenter;
using basic_lesson12_solution4.View;

namespace basic_lesson12_solution4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IOperations
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string IOperations.Num1Text { get => Num1Text.Text; set => Num1Text.Text = value; }
        string IOperations.Num2Text { get => Num2Text.Text; set => Num2Text.Text = value; }
        string IOperations.ResultText { get => ResultText.Text; set => ResultText.Text = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OperationsPresenter presenter = new OperationsPresenter(this);

            try
            {
                if ((bool)PlusRadioB.IsChecked)
                {
                    presenter.Plus();
                }
                else if ((bool)MinusRadioB.IsChecked)
                {
                    presenter.Minus();
                }
                else if ((bool)MultRadioB.IsChecked)
                {
                    presenter.Mult();
                }
                else if ((bool)DivRadioB.IsChecked)
                {
                    presenter.Div();
                }
                else
                {
                    MessageBox.Show("отметье операцию бля");
                }
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
