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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using Presentacion.View.Clients;
using Presentacion.View.Contrats;
using Presentacion.View.Varios;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClienAdmin(object sender, RoutedEventArgs e)
        {
            CLI_Menú win2 = new CLI_Menú();
            win2.Show();
            this.Close();
        }

        private void ClienList(object sender, RoutedEventArgs e)
        {
            CLI_Lista win2 = new CLI_Lista();
            win2.Show();
            this.Close();
        }

        private void ContrAdmin(object sender, RoutedEventArgs e)
        {
            CON_Menú win2 = new CON_Menú();
            win2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Creators win2 = new Creators();
            win2.Show();
            this.Close();
        }

        private void ListaContr(object sender, RoutedEventArgs e)
        {
            CON_Lista win2 = new CON_Lista();
            win2.Show();
            this.Close();
        }

        private void openFly1(object sender, RoutedEventArgs e)
        {
            flyUser.IsOpen = true;
        }
        private void openFly2(object sender, RoutedEventArgs e)
        {
            flyUser.IsOpen = true;
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            Login win2 = new Login();
            this.Close();
            win2.Show();
        }
    }
}
