using forum_system.controller;
using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class Model : IModel
    {
        IController controller;
        DBUtils _db = new DBUtils();

        public void setController(IController controller)
        {
            this.controller = controller;
        }

        public void startDiscussion(Message message)
        {
            throw new NotImplementedException();
        }

        List<string> IModel.getAllSubForums()
        {
            throw new NotImplementedException();
        }

        public bool addDiscussion(Discussion discussion)
        {

            bool ans = false;
            string subForum = discussion.SubForum();
            int disID = discussion.DiscussionID();
            string query = "INSERT INTO discussion_table(openning_message_id, sub_forum_id) VALUES(" + "'" + disID + "', " + "'" + subForum + "')";
            _db.insert(query);
            return ans;
        }
    }
}
