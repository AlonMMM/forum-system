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

        public override void startDiscussion(Message message, string subforum)
        {
            model.startDiscussion(message,subforum);
        }

        public override void addReplytoMessage(Message message)
        {
            model.addCommendaddCommmandtMessage(message);
        }

        public override bool banMember(string userName)
        {
            return model.banMember(userName);
        }

        public override bool unbanMember(string userName)
        {
            return model.unbanMember(userName);
        }
    }

}
