using forum_system.controller.states;
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
        private UserState userState;
        private string user_name;
        private string first_name;
        private string last_name;
        private string password;

        public ForumMember(States state)
        {
            if (state == States.ACTIVE)
                userState = new ActiveState();
            else if (state == States.BANNED)
                userState = new BannedState();
            else if (state == States.NOT_ACTIVE)
                userState = new NotActiveState();
        }
        public ForumMember(string user_name, string first_name, string last_name,string password)
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
    }
}
