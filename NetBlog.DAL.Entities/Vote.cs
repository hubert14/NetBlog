using NetBlog.Utils.Enums;

namespace NetBlog.DAL.Entities
{
    public class Vote
    {
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }

        public int? CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public int UserId { get; set; }
        public virtual Account User { get; set; }

        public VoteType Type { get; set; }
    }
}