using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public class BlogMap : BaseMap<Blog>
    {
        public BlogMap()
        {
            Map(blog => blog.Title);
            Map(blog => blog.ImageUrl).Nullable();

            Map(blog => blog.AuthorId);
            References(blog => blog.Author)
                .ForeignKey("AuthorId")
                .Cascade.Delete();
        }
    }
}