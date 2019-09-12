namespace NetBlog.BLL.Models.Post
{
    public class CreatePostModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public byte[] Image { get; set; }

        public string Content { get; set; }
    }
}