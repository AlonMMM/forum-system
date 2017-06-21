using forum_system.controller;
using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SubForum.xaml
    /// </summary>
    public partial class SubForumWindow : Window
    {
        private IController controller;
        
        string subForumName;
        private List<Discussion> discussionsList;

        public List<Discussion> DiscussionList
        {
            get { return discussionsList; }           
        }


        public SubForumWindow(IController controller, string subForumName)
        {
            InitializeComponent();
            this.controller = controller;
            this.subForumName = subForumName;
            changeVisibility(controller.isAdminLoggedIn());

            discussionsList = controller.getDiscussions(subForumName);
            foreach (Discussion item in discussionsList)
            {
                listViewDiscussions.Items.Add(item.DiscussionID());
            }
        }

        private void changeVisibility(bool isAdmin)
        {
            if (isAdmin)
                addGuide.Visibility = Visibility.Visible;
            else
                addGuide.Visibility = Visibility.Hidden;
        }

        private void listView_Discussions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selectedDiscussion = discussionsList[listViewDiscussions.SelectedIndex].DiscussionID();
            DiscussionWindow discussionW = new DiscussionWindow(controller, selectedDiscussion);
            discussionW.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void add_topic_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class TreeViewModel
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }

    
}


