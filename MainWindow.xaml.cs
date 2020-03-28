
using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
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

namespace HomeDepotDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HomeDepotContext _context;

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new MainPage();
            _context = new HomeDepotContext();
            List<Tool> tools = _context.Tools.ToList<Tool>();
            List<Costumer> costumers = _context.Costumers.ToList<Costumer>();
            this.DataContext = costumers;
        }

        private void mExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new NewC();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        public void GoBack()
        {
            Main.Content = new MainPage();
        }
    }
}
