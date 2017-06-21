using forum_system.model.states;
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
        public override bool addSubForum(string name, string discription)
        {
            return model.addSubForum(name, discription);
        }

        public override List<Discussion> getAllDiscussions(string subForumName)
        {
            return model.getAllDiscussions(subForumName);
        }

        public override List<SubForum> getAllSubForums()
        {
            return model.getAllSubForums();
        }

        public override void startDiscussion(Message message)
        {
            model.startDiscussion(message);
        }
    }
}
