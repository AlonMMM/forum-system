namespace forum_system.model
{
    public class Discassion
    {
        string _subForum;
        int _discussionID;

        public int DiscussionID()
        {
            return _discussionID;
        }
        public string SubForum()
        {
            return _subForum;
        }

        public Discassion(string _subForum, int _discussionID)
        {
            this._subForum = _subForum;
            this._discussionID = _discussionID;
        }
    }
}