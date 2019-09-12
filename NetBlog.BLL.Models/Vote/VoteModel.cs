using NetBlog.Utils.Enums;

namespace NetBlog.BLL.Models.Vote
{
    public class VoteModel : BaseModel
    {
        public int? PostId { get; set; }
        public int? CommentId { get; set; }
        public int UserId { get; set; }

        public VoteType Type { get; set; }
    }
}