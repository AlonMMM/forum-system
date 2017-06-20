using forum_system.controller;
using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public interface IModel
    {
        void setController(IController controller);

        List<SubForum> getAllSubForums();

        void startDiscussion(Message message);
    }
}
