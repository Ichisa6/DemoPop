using Demo.Pages;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AgentListPage());
        }

        //private void Down_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in App.DB.Agent)
        //    {
        //        if (item.Logo != null)
        //        {
        //            var dsd = File.ReadAllBytes($"C:/Users/262023/Desktop{item.Logo}");
        //            item.LogoImage = dsd;
        //        }       
        //        else
        //        {
        //            item.LogoImage = File.ReadAllBytes($"C:/Users/262023/Desktop/agents/picture.png");
        //        }
        //    }
        //    App.DB.SaveChanges();

        //}
    }
}
