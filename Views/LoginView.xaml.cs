using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace CTEDS2022_D10_PickTheWinner.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        //Tentativa de consumo da API... 
        private async void BT_Entrar_Click(object sender, RoutedEventArgs e)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5197/api/User"); 
            }
        }
    }
}
