using forum_system.model.forum_components;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    public class DBService
    {
        DBUtils _dbUtils = new DBUtils();

        public DBService()
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

        //return all the messages for the discussion (not only the first level)
        public List<Message> getAllMessages(int discussId)
        {
            List<Message> messages = new List<Message>();

            string query = "SELECT * FROM message_table WHERE discussion_id = " + discussId;
            OleDbDataReader reader = _dbUtils.select(query);
            Message msg = null;
            while (reader.Read())
            {
                //now we need to build message from id
                int messageID = reader.GetInt32(0);
                string creatorUser = reader.GetString(1);
                string title = reader.GetString(2);
                string content = reader.GetString(3);
                string date = reader.GetString(4);
                int repliedID = reader.GetInt32(5);
                msg = new Message(messageID, creatorUser, title, content, date, repliedID, discussId);
                messages.Add(msg);
            }

            return messages;

        }

        public bool banMember(string userName)
        {
            bool hasSuccessfulyBanned = true;
            string query = "UPDATE user_table SET is_banned = True WHERE user_name = '" + userName + "'";
            try
            {
                _dbUtils.update(query);
            }
            catch (Exception e)
            {
                hasSuccessfulyBanned = false;
            }
            return hasSuccessfulyBanned;
        }

        public bool addSubForum(string name, string discription)
        {
            string query = "INSERT INTO sub_forum_table(sub_forum_name, description) VALUES(" + "'" + name + "', " + "'" + discription + "')";
            bool ans =_dbUtils.insert(query);
            return ans;
        }

        private Message getMessageByID(int messageID)
        {
            string query = "SELECT * FROM message_table WHERE message_id = " + messageID;
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

        public ForumMember login(string username,string passworduser )
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

        public Admin adminLogin(string username, string passworduser)
        {
            Admin admin = null;
            string query = "SELECT * FROM admin_table WHERE user_name = '" + username + "' AND password ='" + passworduser + "'";
            OleDbDataReader reader = _dbUtils.select(query);
            while (reader.Read())
            {
                //now we need to build message from id
                string user_name = reader.GetString(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string password = passworduser;

                admin = new Admin(user_name, first_name, last_name, password);
            }
            return admin;
        }
         
        
       public bool addDiscussionAndMessage(Message msg, string subForum)
        {
            string creator_userName = msg.Creator;
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString();
            bool b = true;
            int id = addFirstMessage(creator_userName, msg.Title, msg.Content, msg.RepliedToId,date);
            if (id != -1)
            {
                addDiscussion(id, subForum);
                updateMessegeDiscussion(id);

            }
            return b;
        }

        public int addFirstMessage(string creator_userName, string title, string content, int replied_to_id, string date)
        {
            int id = -1;
            string query = "INSERT INTO message_table ([creator_userName],[title],[content],[date],[replied_to_id],[discussion_id]) VALUES(" + "'" + creator_userName + "', " + "'" + title + "', '" + content + "','" + date + "',-1,-1)";
            if (_dbUtils.insert(query))
            {
                string query2 = "SELECT max(message_id) FROM message_table";
                OleDbDataReader reader = _dbUtils.select(query2);
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }
        public bool addDiscussion(int id, string subForum)
        {
            string query = "INSERT INTO discussion_table(openning_message_id, sub_forum_id) VALUES(" + id + ", " + "'" + subForum + "')";
            return _dbUtils.insert(query);
        }
        public bool updateMessegeDiscussion(int id)
        {
            string query = " UPDATE message_table SET discussion_id=" + id + " WHERE message_id =" + id;
            return _dbUtils.update(query);
        }

        public bool addCommmandtMessage(string creator_userName, string title, string content, int replied_to_id, string date, int discussion_id )
        {          
            string query = "INSERT INTO message_table ([creator_userName],[title],[content],[date],[replied_to_id],[discussion_id]) VALUES(" + "'" + creator_userName + "', " + "'" + title + "', '" + content + "','" + date + "',"+ replied_to_id + ","+ discussion_id + ")";
            return _dbUtils.insert(query);
            
        }

    }
}
