using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public class Discussion
    {
        private string _subForum;
        private int _discussionID;

        private Message message;

        public Discussion(Message message,string subForumName)
        {
            this.message = message;
            _discussionID = message.ID;
            _subForum = subForumName;
        }

        public int DiscussionID()
        {
            return _discussionID;
        }        

        public Message OpeningMessage
        {
            get { return message; }
            set { message = value; }
        }

        public string SubForum()
        {
            return _subForum;
        }

    }
}
