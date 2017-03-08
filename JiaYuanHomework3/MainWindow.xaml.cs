﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace JiaYuanHomework3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });

            uxList.ItemsSource = users;
        }


        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
            GridViewColumn clickedColumn = (e.OriginalSource as GridViewColumnHeader).Column;
            view.SortDescriptions.Clear();
            if(clickedColumn.Header.ToString()=="Name")
            {
                view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
            }
        }
    }
}
