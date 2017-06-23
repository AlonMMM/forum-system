using forum_system.controller;
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
    /// Interaction logic for addSubForumWindow.xaml
    /// </summary>
    public partial class addDiscussion : Window
    {
        string subForum;
        IController controller;
        public addDiscussion(string subForum,IController controller)
        {
            InitializeComponent();
            this.subForum = subForum;
            this.controller = controller;
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (titleBox.Text=="")
            {
                MessageBox.Show("Please enter title to the message");
            }
            else
            {
                try
                {
                    string content = contectBox.Text;
                    string title = titleBox.Text;
                    controller.addDiscussion(this.subForum, title, content);
                    //here need to update the subForum window with the new topic....
                }
                catch (Exception)
                {

                    MessageBox.Show("Problem with server accur, please try again later.");
                }
                Close();
                
            }
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
