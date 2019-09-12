namespace NetBlog.BLL.Models.Blog
{
    public class CreateBlogModel
    {
        public int AuthorId { get; set; }

        public byte[] Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
