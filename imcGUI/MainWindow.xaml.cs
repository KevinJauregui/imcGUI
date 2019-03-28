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

namespace imcGUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //imcLabel.Content = "";
            EstadoNutricionalLabel.Content = "";
            PesoTextBox.Focus();
            

        }

        private void BotonLimpiar_Click(Object sender, RoutedEventArgs e)
        {
            PesoTextBox.Text = "";
            EstaturaTextBox.Text = "";
            //imcLabel.Content. = "";
            EstadoNutricionalLabel.Content = "";
            //PesoTextBox.Focus();
        }
        
        /*private void PesoTextBox_GotFocus()
        {
            Console.WriteLine("kevn se la come");
        }*/
        private void BotonCalcular_Click(object sender, RoutedEventArgs e)
        {
            string s = PesoTextBox.Text;
            double Peso = Convert.ToDouble(s);
            s = EstaturaTextBox.Text;
            double Estatura = Convert.ToDouble(s);
            double imc = Peso / Math.Pow(Estatura, 2.0);
            double imcLabel = Convert.ToDouble(imc);
            if (imc < 18.5)
            {
                EstadoNutricionalLabel.Content = "Pesos bajo";
                EstadoNutricionalLabel.Foreground = Brushes.Yellow;
            }
            else if (imc < 25.0) 
            {
                EstadoNutricionalLabel.Content = "Pesos Normal";
                EstadoNutricionalLabel.Content = Brushes.Black;
            }
            else if (imc < 30.0) 
            {
                EstadoNutricionalLabel.Content = "Sobrepeso";
                EstadoNutricionalLabel.Content = Brushes.Yellow;
            }
            else if (imc < 40.0) 
            {
                EstadoNutricionalLabel.Content = "Obesisda";
                EstadoNutricionalLabel.Content = Brushes.Orange;
            }
            else
            {
                EstadoNutricionalLabel.Content = "Obesidad Extrema";
                EstadoNutricionalLabel.Content = Brushes.Red;
            }
            EstadoNutricionalLabel.Content = s;
            PesoTextBox.Focus();
            PesoTextBox.SelectAll();
        }
    }
}
