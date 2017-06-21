using forum_system.controller;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        IController controller;
        public Login(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (password.Text == "" || username.Text == "")
            {
                MessageBox.Show("unvalid input");
            }
            else
            {
                try
                {
                    ForumMember member = controller.login(username.Text, password.Text);
                    if (member!=null)
                    {
                        MessageBox.Show("Log in successfully");
                        Close();
                        SubForumSelect subForumWindow = new SubForumSelect(controller);
                        subForumWindow.ShowDialog();
                    }           
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
           
        }
    }
}
