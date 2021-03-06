﻿using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public interface IMember
    {
        void startDiscussion(Message message,string subForum);

        void setState(UserState state);

        bool addSubForum(string name, string discription);

        bool isAdmin();

        void addReplytMessage(Message message);

        string getMemberUserName();

        bool banMember(string userName);

        bool unbanMember(string userName);

        void notifyFriends();

        void notificationReceived(string userName);
    }
}
