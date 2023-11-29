using FriendsWPF;
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

namespace FetchWPF
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        int nextid;
        public AddWindow(int id)
        {
            InitializeComponent();
            nextid = id+1;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (AgeText.Text.Trim() == "" && !(int.TryParse(AgeText.Text.Trim(), out int age)))
            {
                MessageBox.Show("Incorrect age!");
            }
            else if (NameText.Text.Trim() == "")
            {
                MessageBox.Show("Incorrect name!");
            }
            else if(HobbyText.Text.Trim() == "")
            {
                MessageBox.Show("Incorrect hobby!");
            }
            else
            {
                bool? x = MaleAdd.IsChecked;
                bool? y = FemaleAdd.IsChecked;
                string gender = "";
                if (x == true)
                {
                    gender = "M";
                }
                if (y == true)
                {
                    gender = "F";
                }
                People people = new People(nextid,NameText.Text.Trim(),int.Parse(AgeText.Text.Trim()),gender,HobbyText.Text.Trim());
                addwind.Close();
                MessageBox.Show("Sucessfuly added the data");
            }
        }
    }
}
