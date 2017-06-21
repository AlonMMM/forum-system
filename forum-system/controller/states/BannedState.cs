using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.forum_components;
using forum_system.model.exceptions;

namespace forum_system.controller.states
{
    public class BannedState : UserState
    {
        public override bool addSubForum(string name, string discription)
        {
            throw new NoPremissionException("Banned user cannot add sub forum");
        }

        public override List<Discussion> getAllDiscussions(string subForumName)
        {
            throw new NoPremissionException("Banned user cannot see discussions");
        }

        public override List<SubForum> getAllSubForums()
        {
            throw new NoPremissionException("Banned user cannot see the sub forums");
        }

        public override void startDiscussion(Message message)
        {
            throw new NoPremissionException("Banned user cannot start discussion");
        }
    }
}
