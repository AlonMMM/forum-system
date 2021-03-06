﻿using forum_system.model.states;
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

        public override void startDiscussion(Message message, string subforum)
        {
            throw new NoPremissionException("Can't start a discussion while banned");
        }

        public override void addReplytoMessage(Message message)
        {
            throw new NoPremissionException("Cant' reply to messages while banned");
        }

        public override bool banMember(string userName)
        {
            throw new NoPremissionException("Can't ban other members while banned");
        }

        public override bool unbanMember(string userName)
        {
            throw new NoPremissionException("Can't unban other members while banned");
        }
    }

   
}
