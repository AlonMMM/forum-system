using forum_system.model.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model.forum_components
{
    public interface IMember
    {
        void startDiscussion(Message message,string subForum);

        //List<Discussion> getAllDiscussions(string subForumName);

        //List<SubForum> getAllSubForums();

        void setState(States state);

        bool addSubForum(string name, string discription);

        bool isAdmin();
    }
}
