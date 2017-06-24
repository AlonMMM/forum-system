﻿using forum_system.controller.states;
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

        public ForumMember(string user_name, string first_name, string last_name, string password, bool isBanned)
        {
            this.user_name = user_name;
            this.first_name = first_name;
            this.last_name = last_name;
            this.password = password;

            //set state
            if (isBanned)
            {
                userState = new BannedState();
            }
            else
            {
                userState = new ActiveState();
            }
        }


        public void startDiscussion(Message message, string subForum)
        {
            userState.startDiscussion(message, user_name, subForum);
        }



        public virtual bool addSubForum(string name, string discription)
        {
            throw new NoPremissionException("Normal member cannot add sub-forums");
        }

        public void setState(States state)
        {
            if (state == States.ACTIVE)
                userState = new ActiveState();
            else if (state == States.BANNED)
                userState = new BannedState();
            else if (state == States.NOT_ACTIVE)
                userState = new NotActiveState();
        }

        public virtual bool isAdmin()
        {
            return false;
        }
        public void addReplytMessage(Message message)
        {
            userState.addReplytoMessage(message);
        }

        public string getMemberUserName()
        {
            return user_name;
        }

        public virtual bool banMember(string userName)
        {
            throw new NoPremissionException("Forum Members are not allowed to ban other users");
        }

        public virtual bool unbanMember(string userName)
        {
            throw new NoPremissionException("Forum Members are not allowed to unban other users");
        }
    }
}
