using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NetBlog.DAL.Entities;
using NetBlog.ORM.NHibernate.Mapping;
using NHibernate;

namespace NetBlog.ORM.NHibernate
{
    public static class NHibernateHelper
    {
        public static ISession Session { get; private set; }

        public static void Init(string connectionString)
        {
            var sessionFactory = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard
                    .ConnectionString(connectionString))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<BaseMap<BaseEntity>>())
                .BuildSessionFactory();

            Session = sessionFactory.OpenSession();
        }
    }
}