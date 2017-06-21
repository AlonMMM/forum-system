﻿using forum_system.model;
using forum_system.model.states;
using forum_system.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;

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
            return model.getAllDiscussions(subForumName);
        }

        public List<SubForum> getSubForums()
        {
            return model.getAllSubForums();
        }

        public void notifyUser(string message)
        {
            view.notifyUser(message);
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

        public Message getRootMessage(int discussId)
        {
            return model.getRootMessage(discussId);
        }

        public bool addSubForum(string name, string discription)
        {
            return model.addSubForum(name,  discription);
        }
       

        public void addDiscussion(string subForum, string title, string content)
        {
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString();
            member.startDiscussion(new Message("", title,content, date, -1, -1),subForum);
        }
    }
}
