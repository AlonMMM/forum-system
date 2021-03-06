﻿using forum_system.controller;
using forum_system.model.exceptions;
using forum_system.model.forum_components;
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
            changeVisibility(controller.isAdminLoggedIn());

            sub_forum_list = new List<string>();
            foreach (SubForum item in this.controller.getSubForums())
            {
                sub_forum_list.Add(item.Name);
            }

        }

        private void changeVisibility(bool isAdmin)
        {
            if (isAdmin)
            {
                createNewSubForum.Visibility = Visibility.Visible;
                textBlock_ban.Visibility = Visibility.Visible;
            }
            else
            {
                createNewSubForum.Visibility = Visibility.Hidden;
                textBlock_ban.Visibility = Visibility.Hidden;
            }
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
            SubForumWindow subForumWindow = new SubForumWindow(controller, sub_forum_options.Text);
            subForumWindow.ShowDialog();
        }

        private void subForumLoaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = sub_forum_list;
            comboBox.SelectedIndex = 0;
        }

        private void addNewForum(object sender, RoutedEventArgs e)
        {
            AddSubForum addSubForum = new AddSubForum(controller);
            addSubForum.ShowDialog();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            textBox_ban_name.Visibility = Visibility.Visible;
            button_ban.Visibility = Visibility.Visible;
            button_unban.Visibility = Visibility.Visible;
            textBox_ban_name.Text = string.Empty;
        }

        private void button_ban_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Ban Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (controller.banMember(textBox_ban_name.Text))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed. Maybe this user does not exist or already banned?");
                }
            }
        }

        private void button_unban_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Ban Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (controller.unbanMember(textBox_ban_name.Text))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed. Maybe this user does not exist or not banned?");
                }
            }
        }
    }
}
