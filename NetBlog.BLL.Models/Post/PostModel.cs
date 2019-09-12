namespace NetBlog.BLL.Models.Post
{
    public class PostModel : BaseModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }
    }
}
