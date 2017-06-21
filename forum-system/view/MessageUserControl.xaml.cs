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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace forum_system.view
{
    /// <summary>
    /// Interaction logic for message.xaml
    /// </summary>
    public partial class MessageUserControl : UserControl
    {
        private Message singleMessage;

        public Message SingleMessage
        {
            get { return singleMessage; }
            set { singleMessage = value; }
        }

        private List<MessageUserControl> messageUserControlReplies;
        public List<MessageUserControl> MessageUserControlReplies
        {
            get { return messageUserControlReplies; }
            set { messageUserControlReplies = value; }
        }
        IController controller;

        public MessageUserControl(IController controller,Message message)
        {
            InitializeComponent();
            this.controller = controller;
            SingleMessage = message;
            foreach (Message item in SingleMessage.Replies)
            {
                MessageUserControlReplies.Add(new MessageUserControl(controller, item));
            }

        }
    }
}
