using System.Collections.Generic;

namespace NetBlog.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public virtual int AuthorId { get; set; }
        public virtual Account Author { get; set; }

        public virtual bool IsAnonymous { get; set; }

        public virtual string Content { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}