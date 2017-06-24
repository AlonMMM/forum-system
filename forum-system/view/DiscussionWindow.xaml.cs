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
    /// Interaction logic for DiscussionWindow.xaml
    /// </summary>
    /// 


    public partial class DiscussionWindow : Window
    {
        private Message repliedToMessage;

        public Message RepliedToMessage
        {
            get { return repliedToMessage; }
            set { repliedToMessage = value; }
        }
        private Message rootMessage;

        public Message RootMessage
        {
            get { return rootMessage; }
            set { rootMessage = value; }
        }

        private IController controller;


        public DiscussionWindow(IController controller,int messageID)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            DataContext = this;
            this.controller = controller;
            RootMessage = controller.getRootMessage(messageID);
            if (RootMessage != null)
            {
                MessagesTree.ItemsSource = RootMessage.Replies;
            }
        }

        private void AddReplyMessage(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Message message = (Message)button.DataContext;
            AddMessageReply ams = new AddMessageReply(controller, message, this);
            ams.ShowDialog();
            Close();
            //Message selectedTVI = (Message)MessagesTree.SelectedItem;
        }

        private void TreeViewItemSelected(object sender, RoutedEventArgs e)
        {
            //MessagesTree.Tag = e.OriginalSource;
            //Message selectedTVI = MessagesTree.Tag as Message;
            //this.lastSelectedTreeViewItem = tvi;
            Message selectedTVI = (Message)MessagesTree.SelectedItem;
        }

        private void AddReplyToDiscussion(object sender, RoutedEventArgs e)
        {
            AddMessageReply ams = new AddMessageReply(controller, RootMessage, this);
            ams.ShowDialog();
            Close();
        }
    }
}
