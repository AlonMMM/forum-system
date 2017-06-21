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
//            if (username.Text!="" || password.Text!="")
//            {
//                try
//                {
//                  //  ForumMember fm = controller.login(username.Text, password.Text);//add soon
//                   // if (fm==null)
//                    //{
//                      //  MessageBox.Show("rejected");

////                    }
//                    //controller.user = fm;//addsoon
//                    MessageBox.Show("Log in successfully");
//                   // ((MainWindow)Application.Current.MainWindow).notifyMe(user);//change and add
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                    return;
//                }
//            }
            if(true)
            {
                SubForumSelect subForumWindow = new SubForumSelect(controller);
                subForumWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("unvalid input");

            }
        }
    }
}
