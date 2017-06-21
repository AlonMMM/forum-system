using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public class Message
    {
        private int id;
        private string creator;
        private string title;
        private string content;
        private string date;
        private int repliedToId;
        private int discussionId;

        public Message(string creator,string content, string title,string date, int repliedToId , int discussionId)
        {
            this.creator = creator;
            this.title = title;
            this.content = content;
            this.date = date;
            this.RepliedToId = repliedToId;
            this.discussionId = discussionId;
        }

        public Message(int id ,string creator, string content, string title, string date, int repliedToId , int discussionId)
        {
            this.id = id;
            this.creator = creator;
            this.title = title;
            this.content = content;
            this.date = date;
            this.RepliedToId = repliedToId;
            this.discussionId = discussionId;
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

        public int ID {
            get { return this.id; }
        }
    }
}
