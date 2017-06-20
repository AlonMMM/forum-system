using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class DBServise
    {
        DBUtils _dbUtils = new DBUtils();

        public DBServise()
        {
        }

        public List<SubForum> getAllSubForums()
        {
            List<SubForum> subForums = new List<SubForum>();
            string query = "SELECT sub_forum_name FROM sub_forum_table";
            OleDbDataReader reader = _dbUtils.select(query);
            while (reader.Read())
            {
                subForums.Add(new SubForum(reader.GetString(0), reader.GetString(1)));
            }
            return subForums;
        }



        public bool addDiscussion(Discussion discussion)
        {
            bool ans = false;
            string subForum = discussion.SubForum();
            int disID = discussion.DiscussionID();
            string query = "INSERT INTO discussion_table(openning_message_id, sub_forum_id) VALUES(" + "'" + disID + "', " + "'" + subForum + "')";
            _dbUtils.insert(query);
            return ans;
        }

        internal void getAllSubForums(string subForumName)
        {
            throw new NotImplementedException();
        }
    }
}
