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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = string.Empty;
            Operando2TextBox.Text = string.Empty;
            OperacionTextBox.Text = string.Empty;
            ResultadoTextBox.Text = string.Empty;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = int.Parse(Operando1TextBox.Text);
                int num2 = int.Parse(Operando2TextBox.Text);
                char operando = char.Parse(OperacionTextBox.Text);
            
            

                switch (operando)
                {
                    case '*':

                        ResultadoTextBox.Text = (num1 * num2).ToString();

                    break;

                    case '+':

                        ResultadoTextBox.Text = (num1 + num2).ToString();

                    break;

                    case '-':

                        ResultadoTextBox.Text = (num1 - num2).ToString();

                     
                    break;

                    case '/':

                        ResultadoTextBox.Text = (num1 / num2).ToString();

                    break;

                    default:

                        ResultadoTextBox.Text = string.Empty;

                    break;
                }
            }
            catch( Exception exception )
            {
                MessageBox.Show("Revise los Operandos");
            }
            
        }

        private void OperacionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string operador = OperacionTextBox.Text;

            switch (operador)
            {
                case "*":
                case "+":
                case "-":
                case "/":

                    CalcularButton.IsEnabled = true;

                break;

                default:

                    CalcularButton.IsEnabled = false;

                break;
            }
        }
    }
}
