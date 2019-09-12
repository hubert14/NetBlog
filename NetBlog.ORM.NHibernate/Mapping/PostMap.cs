using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public class PostMap : BaseMap<Post>
    {
        public PostMap()
        {
            Map(post => post.Title);
            Map(post => post.SubTitle);
            Map(post => post.ImageUrl).Nullable();
            Map(post => post.Content);

            HasMany(post => post.Votes)
                .Cascade.Delete();
        }
    }
}