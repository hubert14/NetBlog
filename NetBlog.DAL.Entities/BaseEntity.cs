using System;

namespace NetBlog.DAL.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }
        public DateTimeOffset? UpdatedAtUtc { get; set; }
    }
}