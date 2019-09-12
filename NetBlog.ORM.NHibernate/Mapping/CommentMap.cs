using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public class CommentMap : BaseMap<Comment>
    {
        public CommentMap()
        {
            Map(comment => comment.Content);
            Map(comment => comment.IsAnonymous);

            Map(comment => comment.AuthorId);
            References(comment => comment.Author)
                .ForeignKey("AuthorId")
                .Cascade.Delete();
        }
    }
}