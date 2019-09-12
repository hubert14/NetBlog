using FluentNHibernate.Mapping;
using NetBlog.DAL.Entities;

namespace NetBlog.ORM.NHibernate.Mapping
{
    public abstract class BaseMap<TEntity> : ClassMap<TEntity> where TEntity : BaseEntity
    {
        protected BaseMap()
        {
            Id(entity => entity.Id);
            Map(entity => entity.CreatedAtUtc);
            Map(entity => entity.UpdatedAtUtc);
        }
    }
}