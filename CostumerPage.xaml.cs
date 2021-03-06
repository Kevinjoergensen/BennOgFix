﻿using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CostumerPage : Page
    {
       private HomeDepotContext _context;
        public CostumerPage(Costumer costumer)
        {
            _context = new HomeDepotContext();

            InitializeComponent();
            navn.Text = costumer.Name;
            email.Text = costumer.Email;
            brugerid.Text = costumer.Id.ToString();
            brugernavn.Text = costumer.Username;
            password.Text = costumer.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _context.Costumers.AddOrUpdate(t => t.Id, new Costumer { Id = Int32.Parse(brugerid.Text), Name = navn.Text, Email = email.Text, Password = password.Text, Username = brugernavn.Text }) ;
            _context.SaveChanges();
            this.NavigationService.Content = new MainPage();
        }
    }
}
