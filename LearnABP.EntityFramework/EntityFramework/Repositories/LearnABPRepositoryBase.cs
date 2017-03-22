using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace LearnABP.EntityFramework.Repositories
{
    public abstract class LearnABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LearnABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LearnABPRepositoryBase(IDbContextProvider<LearnABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LearnABPRepositoryBase<TEntity> : LearnABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LearnABPRepositoryBase(IDbContextProvider<LearnABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
