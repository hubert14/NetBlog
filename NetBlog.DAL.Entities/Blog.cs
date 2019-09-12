namespace NetBlog.DAL.Entities
{
    public class Blog : BaseEntity
    {
        public virtual int AuthorId { get; set; }
        public virtual Account Author { get; set; }

        public virtual string ImageUrl { get; set; }

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
    }
}