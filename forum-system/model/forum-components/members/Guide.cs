using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.states;
using forum_system.controller.states;
using forum_system.model.exceptions;

namespace forum_system.model.forum_components
{
    class Guide : ForumMember
    {
        public Guide(string user_name, string first_name, string last_name, string password, bool isBanned) 
            : base (user_name, first_name, last_name, password, isBanned)
        {
        }

        public override bool addSubForum(string name, string discription)
        {
            return userState.addSubForum(name, discription);
        }

        public override bool banMember(string userName)
        {
            throw new NoPremissionException("Forum Guides are not allowed to ban other users");
        }

        public override bool unbanMember(string userName)
        {
            throw new NoPremissionException("Forum Guides are not allowed to unban other users");
        }

    }
}
