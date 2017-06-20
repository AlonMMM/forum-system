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
        DBServise _dbService = new DBServise();

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
            throw new NotImplementedException();
        }
    }
}
