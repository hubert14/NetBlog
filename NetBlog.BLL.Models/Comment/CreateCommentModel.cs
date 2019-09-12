namespace NetBlog.BLL.Models.Comment
{
    public class CreateCommentModel
    {
        public int AuthorId { get; set; }

        public bool IsAnonymous { get; set; }

        public string Content { get; set; }
    }
}