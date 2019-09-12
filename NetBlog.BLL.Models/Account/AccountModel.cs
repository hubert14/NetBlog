using System;
using NetBlog.Utils.Enums;

namespace NetBlog.BLL.Models.Account
{
    public class AccountModel : BaseModel
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }

        public DateTimeOffset LastLoginUtc { get; set; }
    }
}
