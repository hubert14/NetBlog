using System;

namespace NetBlog.BLL.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }
        public DateTimeOffset? UpdatedAtUtc { get; set; }
    }
}