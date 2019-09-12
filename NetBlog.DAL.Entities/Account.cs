using System;
using System.Collections.Generic;
using NetBlog.Utils.Enums;

namespace NetBlog.DAL.Entities
{
    public class Account : BaseEntity
    {
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string PasswordHash { get; set; }
        public virtual byte[] PasswordSalt { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string ImageUrl { get; set; }

        public virtual DateTime? Birthday { get; set; }

        public virtual Gender? Gender { get; set; }

        public virtual DateTimeOffset? LastLoginUtc { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}