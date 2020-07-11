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


namespace Presentacion.View.Contrats
{
    /// <summary>
    /// Lógica de interacción para CON_Menú.xaml
    /// </summary>
    public partial class CON_Menú : MetroWindow
    {
        public CON_Menú()
        {
            InitializeComponent();
        }
        private void btnBuscar(object sender, RoutedEventArgs e)
        {
            CON_Buscar win2 = new CON_Buscar();
            win2.Show();
            this.Close();
        }

        private void btnRegistrar(object sender, RoutedEventArgs e)
        {
            CON_Registrar win2 = new CON_Registrar();
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

        private void btnEliminar(object sender, RoutedEventArgs e)
        {
            CON_Eliminar win2 = new CON_Eliminar();
            win2.Show();
            this.Close();
        }

        private void btnLista1(object sender, RoutedEventArgs e)
        {
            CON_Lista win2 = new CON_Lista();
            win2.Show();
            this.Close();
        }

        private void btnLista2(object sender, RoutedEventArgs e)
        {
            CON_Lista win2 = new CON_Lista();
            win2.Show();
            this.Close();
        }
    }
}
