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
using Demo.Model;
namespace Demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditAgentPages.xaml
    /// </summary>
    public partial class AddEditAgentPages : Page
    {
        Agent contextagent;
        public AddEditAgentPages(Agent agent)
        {
            InitializeComponent();
            contextagent = agent;
            DataContext = contextagent;
            CbType.ItemsSource = App.DB.AgentType.ToList();
        }

        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            {
                dialog.Filter = "*.png|*.png|*.jpg|*.jpg|*.jpeg|*.jpeg";
            };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextagent.Logo = System.IO.File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextagent;
            }
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (contextagent.ID == 0)
                {
                    App.DB.Agent.Add(contextagent);
                }

                App.DB.SaveChanges();

                NavigationService.Navigate(new AgentListPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}");
                return;

            }
        }

        private void CanselBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AgentListPage());
        }

        private void DelBt_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Agent.Remove(contextagent);
            App.DB.SaveChanges();

            NavigationService.Navigate(new AgentListPage());
        }
    }
}
