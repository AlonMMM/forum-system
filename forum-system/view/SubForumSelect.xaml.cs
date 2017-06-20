﻿using forum_system.controller;
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

namespace forum_system.view
{
    /// <summary>
    /// Interaction logic for SubForumSelect.xaml
    /// </summary>
    public partial class SubForumSelect : Window
    {
        IController controller;
        List<string> sub_forum_list;

        public SubForumSelect(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
            sub_forum_list = controller.getSubForums();
        }

        private void goToForum_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.Text = comboBox.SelectedItem as string;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {                     
            SubForumWindow createGroup = new SubForumWindow(controller, sub_forum_options.Text);
            createGroup.ShowDialog();
        }

        private void subForumLoaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = sub_forum_list;
            comboBox.SelectedIndex = 0;
        }
    }
}
