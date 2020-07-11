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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace Presentacion.View.Clients
{
    /// <summary>
    /// Lógica de interacción para CLI_Actualizar.xaml
    /// </summary>
    public partial class CLI_Actualizar : MetroWindow
    {
        public CLI_Actualizar()
        {
            InitializeComponent();
            txtRut.Focus();
        }

        private void Volver1(object sender, RoutedEventArgs e)
        {
            CLI_Menú win2 = new CLI_Menú();
            win2.Show();
            this.Close();
        }

        private void Volver2(object sender, RoutedEventArgs e)
        {
            CLI_Menú win2 = new CLI_Menú();
            win2.Show();
            this.Close();
        }

        private void ListaClick(object sender, RoutedEventArgs e)
        {
            CLI_Lista win2 = new CLI_Lista();
            win2.Show();
            this.Close();
        }

        private void ListaClick2(object sender, RoutedEventArgs e)
        {
            CLI_Lista win2 = new CLI_Lista();
            win2.Show();
            this.Close();
        }
    }
}
