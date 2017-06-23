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
    public class BannedState : UserState
    {
        public override bool addSubForum(string name, string discription)
        {
            throw new NoPremissionException("Normal member cannot add sub-forums");
        }

        public override void startDiscussion(Message message, string creator, string subforum)
        {
            view.notifyUser("You are banned! Can't start a discussion");
        }

        public override void addReplytMessage(Message message)
        {
            view.notifyUser("You are banned! Can't start a discussion");
        }
    }

   
}
