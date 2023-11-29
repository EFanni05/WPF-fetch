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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        List<People> people;

        public Search(List<People> peoples)
        {
            InitializeComponent();
            people = peoples;
        }

        private void search(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(ageTextbox.Text.Trim(), out int age))
            {
                List<People> searchPeople = new List<People>();
                if (hobbyTextbox.Text.Trim() == ""){
                    bool? x = Male.IsChecked;
                    bool? y = Female.IsChecked;
                    string gender = "";
                    if (x == true)
                    {
                        gender = "M";
                    }
                    if (y == true)
                    {
                        gender = "F";
                    }
                    searchPeople = people.FindAll(x => x.Gender == gender).ToList<People>();
                }
                else
                {
                    bool? x = Male.IsChecked;
                    bool? y = Female.IsChecked;
                    string gender = "";
                    if (x == true)
                    {
                        gender = "M";
                    }
                    if (y == true)
                    {
                        gender = "F";
                    }
                    string hobby = hobbyTextbox.Text.Trim();
                    searchPeople = people.FindAll(x => x.Hobby == hobby).FindAll(x => x.Gender == gender).ToList<People>();
                }
                if (searchlist.Items.Count > 0)
                {
                    searchlist.Items.Clear();
                }
                for (int i = 0; i < searchPeople.Count; i++)
                {
                    searchlist.Items.Add(searchPeople[i].ToString());
                }
            }
            else if(hobbyTextbox.Text.Trim() == "")
            {
                List<People> searchPeople = new List<People>();
                if (!int.TryParse(ageTextbox.Text.Trim(), out int age1))
                {
                    bool? x = Male.IsChecked;
                    bool? y = Female.IsChecked;
                    string gender = "";
                    if (x == true)
                    {
                        gender = "M";
                    }
                    if (y == true)
                    {
                        gender = "F";
                    }
                    searchPeople = people.FindAll(x => x.Gender == gender).ToList<People>();
                }
                else
                {
                    bool? x = Male.IsChecked;
                    bool? y = Female.IsChecked;
                    string gender = "";
                    if (x == true)
                    {
                        gender = "M";
                    }
                    if (y == true)
                    {
                        gender = "F";
                    }
                    searchPeople = people.FindAll(x => x.Age == age).FindAll(x => x.Gender == gender).ToList<People>();
                }
                if (searchlist.Items.Count > 0)
                {
                    searchlist.Items.Clear();
                }
                for (int i = 0; i < searchPeople.Count; i++)
                {
                    searchlist.Items.Add(searchPeople[i].ToString());
                }
            }
            else
            {
                string hobby = hobbyTextbox.Text.Trim();
                bool? x = Male.IsChecked;
                bool? y = Female.IsChecked;
                string gender = "";
                if (x == true)
                {
                    gender = "M";
                }
                if (y == true)
                {
                    gender = "F";
                }
                List<People> searchPeople = people.FindAll(x => x.Age == age).FindAll(x => x.Hobby == hobby).FindAll(x => x.Gender == gender).ToList<People>();
                if (searchlist.Items.Count > 0)
                {
                    searchlist.Items.Clear();
                }
                for (int i = 0; i < searchPeople.Count; i++)
                {
                    searchlist.Items.Add(searchPeople[i].ToString());
                }
            }
        }
    }
}
