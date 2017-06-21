using forum_system.model;
using forum_system.model.states;
using forum_system.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;

namespace forum_system.controller
{
    public class Forum : IController
    {
        private IModel model;
        private IView view;
        
        public Forum(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            UserState.initializeState(view, model);
        }

        public List<Discussion> getDiscussions(string subForumName)
        {
            return model.getAllDiscussions(subForumName);
        }

        public List<SubForum> getSubForums()
        {
            return model.getAllSubForums();
        }

        //if contain return true
        public void notifyUser(string message)
        {
            view.notifyUser(message);
        }
        public bool Contain(string name)
        {
            List<SubForum> subForumList= getSubForums();
            foreach (var SubForum in subForumList)
            {
                if (SubForum.Name== name)
                {
                    return true;
                }
            }
            return false;
        }

        void IController.notifyUser(string message)
        {
            throw new NotImplementedException();
        }

        public ForumMember login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Message getRootMessage(int discussId)
        {
            return model.getRootMessage(discussId);
        }

        public bool addSubForum(string name, string discription)
        {

            return model.addSubForum( name,  discription);
        }
        public bool addDiscussionAndMessage(string title,string contentMessege)
        {
            return model.addDiscussionAndMessage(title, contentMessege);
        }
    }
}
