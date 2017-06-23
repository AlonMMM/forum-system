using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.controller
{
    public interface IController
    {
        void notifyUser(string message);

        List<SubForum> getSubForums();

        List<Discussion> getDiscussions(string subForumName);      
        
        bool isSubForumNameTaken(string name);

        bool login(string userName, string password);

        bool adminLogin(string userName, string password);

        Message getRootMessage(int discussId);

        bool addSubForum(string name , string discription);

        void addDiscussion(string subForum, string title, string content);

        bool isAdminLoggedIn();

        void addReplytMessage(Message message);

        bool banMember(string userName);
    }

    
}
