namespace NetBlog.DAL.Entities
{
    public class Blog : BaseEntity
    {
        public int AuthorId { get; set; }
        public virtual Account Author { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }
    }
}