using System;
using NetBlog.Utils.Enums;

namespace NetBlog.BLL.Models.Account
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }

        public byte[] Image { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? Birthday { get; set; }

        public Gender? Gender { get; set; }
    }
}