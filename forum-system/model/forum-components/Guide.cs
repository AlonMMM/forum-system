using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.states;
using forum_system.controller.states;

namespace forum_system.model.forum_components
{
    class Guide : ForumMember
    {
        public Guide(string user_name, string first_name, string last_name, string password) 
            : base (user_name, first_name, last_name, password)
        {
            userState = new ActiveState();
        }
    }
}
