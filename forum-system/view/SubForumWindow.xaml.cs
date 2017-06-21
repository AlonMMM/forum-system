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
        IController controller;
        List<Discussion> discussionsList;
        string subForumName;
        public SubForumWindow(IController controller, string subForumName)
        {
            InitializeComponent();
            this.controller = controller;
            this.subForumName = subForumName;
            discussionsList = controller.getDiscussions(subForumName);
        }

        public TreeViewModel TreeModel
        {
            get
            {
                return new TreeViewModel
                {
                    Items = new ObservableCollection<NodeMessage>{
                           new NodeMessage { Name = "Root", Children =  new ObservableCollection<NodeMessage> {
                              new NodeMessage { Name = "Level1" ,  Children = new ObservableCollection<NodeMessage>{
                                  new NodeMessage{ Name = "Level2"}}} } }}
                };
            }
        }
        public Message createHierarchy(List<Message> messageList)
        {

            return null;
        }
    }

    public class TreeViewModel
    {
        public ObservableCollection<NodeMessage> Items { get; set; }
    }

    public class NodeMessage
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<NodeMessage> Children { get; set; }
    }
    
}


