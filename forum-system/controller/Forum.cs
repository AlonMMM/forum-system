using forum_system.model;
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

        public Forum(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            UserState.initializeState(view, model);
        }

        public void notifyUser(string message)
        {
            view.notifyUser(message);
        }
    }
}
