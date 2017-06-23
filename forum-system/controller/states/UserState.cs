using forum_system.controller;
using forum_system.model.forum_components;
using forum_system.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.states
{
    public abstract class UserState
    {
        protected static IView view;
        protected static IModel model;

        public static void initializeState(IView appliedView, IModel appliedModel)
        {
            view = appliedView;
            model = appliedModel;
        }

        public abstract void startDiscussion(Message message, string userName,string subforum);

        public abstract bool addSubForum(string name, string discription);

        public abstract void addCommendaddCommmandtMessage(Message message);

    }


    public enum States
    {
        BANNED,
        ACTIVE,
        NOT_ACTIVE
    };
}
