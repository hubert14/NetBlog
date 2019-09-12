using System;

namespace NetBlog.DAL.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTimeOffset CreatedAtUtc { get; set; }
        public virtual DateTimeOffset? UpdatedAtUtc { get; set; }
    }
}