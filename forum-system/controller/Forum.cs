﻿using forum_system.model;
using forum_system.model.states;
using forum_system.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;
using forum_system.model.exceptions;

namespace forum_system.controller
{
    public class Forum : IController
    {
        private IModel model;
        private IView view;
        private IMember member;  
              
        public Forum(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            UserState.initializeState(view, model);
        }

        public List<Discussion> getDiscussions(string subForumName)
        {
            try
            {
                return member.getAllDiscussions(subForumName);
            }
            catch (NoPremissionException e)
            {
                view.notifyUser(e.Message);
                return null;              
            }
        }

        public List<SubForum> getSubForums()
        {
            try
            {
                return member.getAllSubForums();
            }
            catch (NoPremissionException e)
            {
                view.notifyUser(e.Message);
                return null;
            }
        }

        public bool addSubForum(string name, string discription)
        {
            try
            {
                return member.addSubForum(name, discription);
            }
            catch (NoPremissionException e)
            {
                view.notifyUser(e.Message);
                return false;
            }
        }

        public Message getRootMessage(int discussId)
        {
            return model.getRootMessage(discussId);
        }

        public bool login(string userName, string password)
        {
            member = model.login(userName, password);
            return member != null;
        }

        public bool adminLogin(string userName, string password)
        {
            member = model.adminLogin(userName, password);
            return member != null;
        }

        public bool isAdminLoggedIn()
        {
            if (member == null)
                return false;
            return member.isAdmin();
        }

        //if contain return true
        public bool Contain(string name)
        {
            List<SubForum> subForumList = getSubForums();
            foreach (var SubForum in subForumList)
            {
                if (SubForum.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void notifyUser(string message)
        {
            view.notifyUser(message);
        }
        public bool addDiscussionAndMessage(string title,string contentMessege)
        {
            return model.addDiscussionAndMessage(title, contentMessege);
        }
    }
}
