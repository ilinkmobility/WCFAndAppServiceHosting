using Newtonsoft.Json.Linq;
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

namespace RESTClient.WPF
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://localhost:80/Temporary_Listen_Addresses/EMICalculator/emi";
            string json = "{\"amount\": " + txtAmount.Text + ",\"period\": " + txtPeriod.Text + ",\"rate\": " + txtRate.Text + " }";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
                string result = await response.Content.ReadAsStringAsync();

                dynamic dynamicResult = JObject.Parse(result);

                lblResult.Text = "EMI : " + dynamicResult.emiResult;
            }
        }
    }
}
