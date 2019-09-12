using FluentNHibernate.Mapping;
using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public class VoteMap : BaseMap<Vote>
    {
        public VoteMap()
        {
            Map(vote => vote.Type);

            Map(vote => vote.PostId).Nullable();
            References(vote => vote.Post)
                .ForeignKey("PostId")
                .Cascade.Delete();

            Map(vote => vote.CommentId).Nullable();
            References(vote => vote.Comment)
                .ForeignKey("CommentId")
                .Cascade.Delete();

            Map(vote => vote.UserId);
            References(vote => vote.User)
                .ForeignKey("UserId")
                .Cascade.Delete();
        }
    }
}