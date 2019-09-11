using System.Collections.Generic;

namespace NetBlog.DAL.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}