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
            string query = "SELECT * FROM sub_forum_table";
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

        public List<Discussion> getAllSubForums(string subForumName)
        {
            List<Discussion> discussons = new List<Discussion>();
            //first get all recored that match
            string query = "SELECT * FROM discussion_table WHERE sub_forum_id = "+"'"+subForumName+"'";
            OleDbDataReader reader = _dbUtils.select(query);
            while (reader.Read())
            {
                //now we need to build message from id
                int messageID = reader.GetInt32(0);
                Message msg = getMessageByID(messageID);
                discussons.Add(new Discussion(msg,subForumName));
            }
            return discussons;
        }

        private Message getMessageByID(int messageID)
        {
            string query = "SELECT * FROM message_table WHERE message_id = " + "'" + messageID + "'";
            OleDbDataReader reader = _dbUtils.select(query);
            Message msg = null;
            while (reader.Read())
            {
                //now we need to build message from id
                string creatorUser = reader.GetString(1);
                string title = reader.GetString(2);
                string content = reader.GetString(3);
                string date = reader.GetString(4);
                int repliedID = reader.GetInt32(5);
                int discussId = reader.GetInt32(6);
                msg = new Message(messageID, creatorUser, title, content, date, repliedID, discussId);
            }

            return msg;
        }

        private ForumMember login(string username,string passworduser )
        {
            ForumMember member = null;
            string query = "SELECT * FROM user_table WHERE user_name = '" + username+ "' AND password ='" + passworduser + "'";
            OleDbDataReader reader = _dbUtils.select(query);
            while (reader.Read())
            {

                //now we need to build message from id
                string user_name = reader.GetString(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string password = passworduser;

                member = new ForumMember(user_name, first_name, last_name,  password);
            }

            return member;
        }

    }
}
