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
        private Message rootMessage;

        public Message RootMessage
        {
            get { return rootMessage; }
            set { rootMessage = value; }
        }
        public DiscussionWindow(IController controller,int messageID)
        {
            InitializeComponent();            
            RootMessage = controller.getRootMessage(messageID);
            MessagesTree.ItemsSource = RootMessage.Replies;
        }
    }
}
