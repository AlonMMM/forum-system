using forum_system.controller;
using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class Model : IModel
    {
        IController controller;
        DBService _dbService = new DBService();

        public void setController(IController controller)
        {
            this.controller = controller;
        }

        public void startDiscussion(Message message)
        {
            throw new NotImplementedException();
        }

        public List<SubForum> getAllSubForums()
        {
            return _dbService.getAllSubForums();
        }

        public bool addDiscussion(Discussion discussion)
        {

            return _dbService.addDiscussion(discussion);
        }

        public List<Discussion> getAllDiscussions(string subForumName)
        {
            return _dbService.getAllSubForums(subForumName);
        }


        public ForumMember login(string userName, string password)
        {
            return _dbService.login(userName, password);
        }

        public Admin adminLogin(string userName, string password)
        {
            return _dbService.adminLogin(userName, password);
        }

        //return message with list in it and recursivly contain all the message of the discuss
        public Message getRootMessage(int discussId)
        {
            Message msg = null;

            List<Message> allMessages = _dbService.getAllMessages(discussId);
            msg = buildRootMessage(allMessages);
            return msg;
        }

        private Message buildRootMessage(List<Message> allMessages)
        {
            int indexOfRoot = 0;
            int counter = 0;
            foreach (Message son in allMessages)
            {
                if (son.RepliedToId == -1)
                    //this is the root index, have no father
                    indexOfRoot = counter;
                counter++;
                foreach (Message father in allMessages)
                {
                    //finde the father in list and add to his message list the son message
                    if (father.ID == son.RepliedToId)
                        father.addToReplies(son);
                }
            }

            return allMessages.ElementAt(indexOfRoot);
        }

        public bool addSubForum(string name, string discription)
        {
            return _dbService.addSubForum(name, discription);
        }
    }
}
