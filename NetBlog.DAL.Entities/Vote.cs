using NetBlog.Utils.Enums;

namespace NetBlog.DAL.Entities
{
    public class Vote : BaseEntity
    {
        public virtual int? PostId { get; set; }
        public virtual Post Post { get; set; }

        public virtual int? CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public virtual int UserId { get; set; }
        public virtual Account User { get; set; }

        public virtual VoteType Type { get; set; }
    }
}