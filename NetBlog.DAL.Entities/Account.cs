using System;
using System.Collections.Generic;
using NetBlog.Utils.Enums;

namespace NetBlog.DAL.Entities
{
    public class Account : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }

        public DateTimeOffset LastLoginUtc { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}