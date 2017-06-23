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
            view.notifyUser("Can't start a discussion while account is not active. Re-activate your account to perform this action");
        }

        public override void addReplytoMessage(Message message)
        {
            view.notifyUser("Can't reply to messages while account is not active. Re-activate your account to perform this action");

        }

        public override bool banMember(string userName)
        {
            throw new NoPremissionException("Can't ban other members while account is not active. Re-activate your account to perform this action");
        }
    }
}
