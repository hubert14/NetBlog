using System.Collections.Generic;

namespace NetBlog.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public int AuthorId { get; set; }
        public virtual Account Author { get; set; }

        public bool IsAnonymous { get; set; }

        public string Content { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}