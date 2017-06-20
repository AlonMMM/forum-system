using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forum_system.model.states;

namespace forum_system.model.forum_components
{
    class Admin : ForumMember
    {
        public Admin(States state) : base(state)
        {
        }
    }
}
