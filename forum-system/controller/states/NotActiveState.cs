using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;
using forum_system.model.exceptions;

namespace forum_system.controller.states
{
    public class NotActiveState : UserState
    {
        public override bool addSubForum(string name, string discription)
        {
            throw new NoPremissionException("Normal member cannot add sub-forums");
        }

        public override void startDiscussion(Message message, string creator, string subforum)
        {
            view.notifyUser("Your account is not active. If you with you start a discussion, please re-activate your account.");
        }

        public override void addCommendaddCommmandtMessage(Message message)
        {
            view.notifyUser("Your account is not active. If you with you start a discussion, please re-activate your account.");

        }
    }
}
