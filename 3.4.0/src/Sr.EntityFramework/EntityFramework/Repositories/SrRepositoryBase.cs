using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Sr.EntityFramework.Repositories
{
    public abstract class SrRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SrDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SrRepositoryBase(IDbContextProvider<SrDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SrRepositoryBase<TEntity> : SrRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SrRepositoryBase(IDbContextProvider<SrDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
