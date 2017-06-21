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


