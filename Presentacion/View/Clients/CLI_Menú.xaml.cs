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
    /// Lógica de interacción para CLI_Menú.xaml
    /// </summary>
    public partial class CLI_Menú : MetroWindow
    {
        public CLI_Menú()
        {
            InitializeComponent();
        }
        private void btnBuscar(object sender, RoutedEventArgs e)
        {
            CLI_Buscar win2 = new CLI_Buscar();
            win2.Show();
            this.Close();
        }

        private void btnRegistrar(object sender, RoutedEventArgs e)
        {
            CLI_Registrar win2 = new CLI_Registrar();
            win2.Show();
            this.Close();
        }

        private void btnActualizar(object sender, RoutedEventArgs e)
        {
            CLI_Actualizar win2 = new CLI_Actualizar();
            win2.Show();
            this.Close();
        }

        private void btnEliminar(object sender, RoutedEventArgs e)
        {
            CLI_Eliminar win2 = new CLI_Eliminar();
            win2.Show();
            this.Close();
        }

        private void btnVolver(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void btnVolver2(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Lista1_Click(object sender, RoutedEventArgs e)
        {
            CLI_Lista win2 = new CLI_Lista();
            win2.Show();
            this.Close();
        }
        private void Lista2_Click(object sender, RoutedEventArgs e)
        {
            CLI_Lista win2 = new CLI_Lista();
            win2.Show();
            this.Close();
        }
    }
}
