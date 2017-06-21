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
        private IController controller;


        public Login(IController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (password.Text == "" || username.Text == "")
            {
                MessageBox.Show("invalid input");
            }
            else
            {
                try
                {
                    bool logInSuccess;
                    if (checkBox_admin.IsChecked == true)
                        logInSuccess = controller.adminLogin(username.Text, password.Text);
                    else
                        logInSuccess = controller.login(username.Text, password.Text);

                    if (logInSuccess == true)
                    {
                        MessageBox.Show("Log in successfully");
                        SubForumSelect subForumWindow = new SubForumSelect(controller);
                        subForumWindow.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bad username or password");
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
