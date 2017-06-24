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
        private ObservableCollection<string> discussionsSubjects;
        private List<Discussion> discussionsList;
        private IController controller;
        private string subForumName;

        public List<Discussion> DiscussionList
        {
            get { return discussionsList; }           
        }


        public SubForumWindow(IController controller, string subForumName)
        {
            InitializeComponent();
            this.controller = controller;
            this.subForumName = subForumName;
            discussionsList = controller.getDiscussions(subForumName);
            discussionsSubjects = controller.getDiscussionsSubjects(subForumName);
            listViewDiscussions.ItemsSource = discussionsSubjects;

            //if (discussionsList != null)
            //{
            //    foreach (Discussion item in discussionsList)
            //    {
            //        listViewDiscussions.Items.Add(item.OpeningMessage.Title);
            //    }
            //}
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
            Window addDiscussion = new addDiscussion(subForumName , controller, discussionsSubjects, this);
            addDiscussion.Show();
        }

        internal void refreshDiscussions()
        {
            discussionsList = controller.getDiscussions(subForumName);
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


