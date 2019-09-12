using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public class AccountMap : BaseMap<Account>
    {
        public AccountMap()
        {
            Map(account => account.Email);
            Map(account => account.Username);

            Map(account => account.FirstName);
            Map(account => account.LastName);

            Map(account => account.PasswordHash);
            Map(account => account.PasswordSalt);

            Map(account => account.Gender).Nullable();

            Map(account => account.PhoneNumber).Nullable();

            Map(account => account.ImageUrl).Nullable();

            Map(account => account.Birthday).Nullable();

            Map(account => account.LastLoginUtc).Nullable();

            HasMany(account => account.Votes)
                .Cascade.Delete();

            HasMany(account => account.Blogs)
                .Cascade.Delete();

            HasMany(account => account.Comments)
                .Cascade.Delete();
        }
    }
}