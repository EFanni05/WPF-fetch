using FetchWPF;
using Newtonsoft.Json;
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

namespace FriendsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string link = "https://retoolapi.dev/nuBvDe/peoples";
        List<People> peoples;

        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            peoples = ListGet();
        }

        public List<People> ListGet()
        {
            string x = client.GetStringAsync(link).Result;
            List<People> list = JsonConvert.DeserializeObject<List<People>>(x);
            return list;
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            if(List.Items.Count > 0)
            {
                List.Items.Clear();
            }
            for (int i = 0; i < peoples.Count; i++)
            {
                List.Items.Add(peoples[i].ToString());
            }   
        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if(List.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select an item to delete");
            }
            else
            {
                //i know this isnt the prettiest
                string item = List.SelectedItem.ToString();
                string x = item.Substring(0, 3).Replace('.', ' ').Trim();
                int id = int.Parse(x);
                People delete = peoples.Find(x => x.Id == id);
                peoples.Remove(delete);
                MessageBox.Show("Please load it again the list");
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {

        }
    }
}
