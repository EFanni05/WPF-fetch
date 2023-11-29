﻿using FetchWPF;
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

        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            List<People> peoples = List();
        }

        public List<People> List()
        {
            string x = client.GetStringAsync(link).Result;
            List<People> list = JsonConvert.DeserializeObject<List<People>>(x);
            return list;
        }
    }
}
