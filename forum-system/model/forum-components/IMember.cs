using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    interface IMember
    {
        void startDiscussion(Message message);
    }
}
