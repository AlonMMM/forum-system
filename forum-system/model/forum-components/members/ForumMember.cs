using forum_system.controller.states;
using forum_system.model.exceptions;
using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public class ForumMember : IMember
    {
        protected UserState userState;
        protected string user_name;
        protected string first_name;
        protected string last_name;
        protected string password;

        public ForumMember(string user_name, string first_name, string last_name, string password)
        {
            this.user_name = user_name;
            this.first_name = first_name;
            this.last_name = last_name;
            this.password = password;

            userState = new ActiveState();
        }

        public void startDiscussion(Message message)
        {
            userState.startDiscussion(message);
        }

        public virtual bool isAdmin()
        {
            return false;
        }

        public List<Discussion> getAllDiscussions(string subForumName)
        {
            return userState.getAllDiscussions(subForumName);
        }

        public List<SubForum> getAllSubForums()
        {
            return userState.getAllSubForums();
        }

        public virtual bool addSubForum(string name, string discription)
        {
            throw new NoPremissionException("Normal member cannot add sub-forums");
        }

        protected void setState(States state)
        {
            if (state == States.ACTIVE)
                userState = new ActiveState();
            else if (state == States.BANNED)
                userState = new BannedState();
            else if (state == States.NOT_ACTIVE)
                userState = new NotActiveState();
        }
    }
}
