using System.Collections.Generic;

namespace NetBlog.DAL.Entities
{
    public class Post : BaseEntity
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }

        public virtual string ImageUrl { get; set; }

        public virtual string Content { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}