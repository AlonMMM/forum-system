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
    /// Interaction logic for AddMessageReply.xaml
    /// </summary>
    public partial class AddMessageReply : Window
    {
        IController controller;
        Message message;

        public AddMessageReply(IController controller,Message message)
        {
            InitializeComponent();
            this.controller = controller;
            this.message = message;
        }
        
    

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {

            if (titleBox.Text == "")
            {
                MessageBox.Show("Please enter title to the message");
            }
            else
            {
                try
                {
                    string content = contectBox.Text;
                    string title = titleBox.Text;
                    DateTime localDate = DateTime.Now;
                    string date = localDate.ToString();
                    controller.addReplytMessage(new Message("", contectBox.Text, titleBox.Text, date, message.ID,message.DiscussionId));
                    DiscussionWindow dw = new DiscussionWindow(controller, message.DiscussionId);
                    dw.ShowDialog();
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
            DiscussionWindow dw = new DiscussionWindow(controller, message.DiscussionId);
            dw.ShowDialog();
            Close();
        }
    }
}
