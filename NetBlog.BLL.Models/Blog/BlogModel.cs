namespace NetBlog.BLL.Models.Blog
{
    public class BlogModel : BaseModel
    {
        public int AuthorId { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
