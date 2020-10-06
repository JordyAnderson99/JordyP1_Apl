using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JordyP1_Apl.BLL;
using JordyP1_Apl.Entidades;

namespace JordyP1_Apl.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cPrestamos.xaml
    /// </summary>
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
            var listado = new List<Ciudades>();

            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch(FiltroComboBox.SelectedIndex){
                    case 1:{
                        listado = CiudadesBLL.GetList(e => e.CiudadId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    }
                    case 2:{
                        listado= CiudadesBLL.GetList(e => e.Nombre.Contains(CriterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                        break;
                    }
                }
            }
            else
            {
                listado= CiudadesBLL.GetList(p => true);
            }
                Consulta.ItemsSource = null;
                Consulta.ItemsSource = listado;
            
        }
    }
}