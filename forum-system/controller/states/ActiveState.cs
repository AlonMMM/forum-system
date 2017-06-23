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

        public override void startDiscussion(Message message,string creator, string subforum)
        {
            message.Creator = creator;
            model.startDiscussion(message,subforum);
        }

        public override void addCommendaddCommmandtMessage(Message message)
        {
            model.addCommendaddCommmandtMessage(message);
        }
    }

}
