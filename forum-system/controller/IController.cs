﻿using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.controller
{
    public interface IController
    {
        void notifyUser(string message);

        List<SubForum> getSubForums();

        List<Discussion> getDiscussions(string subForumName);

        ForumMember login(string userName, string password);
        
    }

    
}
