using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public class Message
    {
        private string content;
        private string title;
        private int repliedToId;

        public Message(string content, string title, int repliedToId)
        {
            this.content = content;
            this.title = title;
            this.RepliedToId = repliedToId;
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int RepliedToId
        {
            get
            {
                return repliedToId;
            }

            set
            {
                repliedToId = value;
            }
        }
    }
}
