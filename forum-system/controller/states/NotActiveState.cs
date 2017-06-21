using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;

namespace forum_system.controller.states
{
    public class NotActiveState : UserState
    {
        public override void startDiscussion(Message message, string creator, string subforum)
        {
            view.notifyUser("Your account is not active. If you with you start a discussion, please re-activate your account.");
        }
    }
}
