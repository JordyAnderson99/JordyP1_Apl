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
using JordyP1_Apl.UI.Registro;
using JordyP1_Apl.UI.Consulta;

namespace JordyP1_Apl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroCiudadesButton_Click(object sender, RoutedEventArgs e){
            rCiudades rPro = new rCiudades();
            rPro.Show();
        }


        private void ConsultaCiudadesButton_Click(object sender, RoutedEventArgs e){
           cCiudades cCiu = new cCiudades();
            cCiu.Show();
        }
    }
}
