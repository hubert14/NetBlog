namespace NetBlog.BLL.Models.Comment
{
    public class CommentModel : BaseModel
    {
        public int AuthorId { get; set; }

        public bool IsAnonymous { get; set; }

        public string Content { get; set; }
    }
}