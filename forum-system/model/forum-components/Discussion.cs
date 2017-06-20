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

        public Discussion(Message message)
        {
            this.message = message;
        }

        public int DiscussionID()
        {
            return _discussionID;
        }

        public string SubForum()
        {
            return _subForum;
        }

    }
}
