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
using Negocio.Models;

namespace Presentacion.View.Clients
{
    /// <summary>
    /// Lógica de interacción para CLI_Lista.xaml
    /// </summary>
    public partial class CLI_Lista : MetroWindow
    {
        private readonly Cliente cliente;

        public CLI_Lista()
        {
            cliente = new Cliente();

            InitializeComponent();

            ListaClientesdatagrid.ItemsSource = cliente.GetAll();
        }

        private void Volver1(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }
        private void Volver2(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }
        private void AdminClien1(object sender, RoutedEventArgs e)
        {
            CLI_Menú win2 = new CLI_Menú();
            win2.Show();
            this.Close();
        }
        private void AdminClien2(object sender, RoutedEventArgs e)
        {
            CLI_Menú win2 = new CLI_Menú();
            win2.Show();
            this.Close();
        }
    }
}
