using forum_system.controller;
using System;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using forum_system.model.exceptions;

namespace forum_system.view
{
    /// <summary>
    /// Interaction logic for addSubForumWindow.xaml
    /// </summary>
    public partial class addDiscussion : Window
    {
        string subForum;
        IController controller;
        private ObservableCollection<string> discussionsSubjects;
        private SubForumWindow subForumWindow;

        public addDiscussion(string subForum,IController controller)
        {
            InitializeComponent();
            this.subForum = subForum;
            this.controller = controller;
        }

        public addDiscussion(string subForum, IController controller, ObservableCollection<string> discussionsSubjects, SubForumWindow subForumWindow) : this(subForum, controller)
        {
            this.discussionsSubjects = discussionsSubjects;
            this.subForumWindow = subForumWindow;
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
                    discussionsSubjects.Add(title);
                    subForumWindow.refreshDiscussions();
                }
                catch (NoPremissionException exp)
                {
                    MessageBox.Show(exp.Message);
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
