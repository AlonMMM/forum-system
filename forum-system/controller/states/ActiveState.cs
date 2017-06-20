﻿using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;

namespace forum_system.controller.states
{
    public class ActiveState : UserState
    {
        public override void startDiscussion(Message message)
        {
            model.startDiscussion(message);
        }
    }
}
