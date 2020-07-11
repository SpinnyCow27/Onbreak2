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

namespace Presentacion.View.Varios
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "user" && txtPassword.Password == "admin")
            {
                MainWindow win2 = new MainWindow();
                win2.Show();
                this.Close();
            }
            else
            {
                await this.ShowMessageAsync("Error!", "Verifica tus datos");
            }
        }

    }
}
