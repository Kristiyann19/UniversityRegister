using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace Ur.Repositories.Base
{
    public interface IRepositoryBase<TEntity, TFilterDto>
         //where TFilterDto : IFilterDto<TEntity>
    {
        IDbContextTransaction BeginTransaction();

        Task<TEntity> GetById(int id, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null);
        Task<TEntity> GetByProperties(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null);
        Task<List<TEntity>> GetListByProperties(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null);
        Task<List<TEntity>> GetList(TFilterDto filerDto, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        Task<(List<TEntity>, int)> GetAll(TFilterDto filerDto, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        IQueryable<TEntity> GetQuery(TFilterDto filerDto, CancellationToken cancellationToken, Func<IQueryable<TEntity>, IQueryable<TEntity>> includesFunc = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        Task<bool> AnyEntity(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task Create(TEntity entity);
        Task CreateRange(List<TEntity> entities);
        Task SaveEntityChanges(TEntity entity);
        Task SaveEntitiesChanges(List<TEntity> entities);
        Task Update(TEntity entity, TEntity modificationEntity);
        Task UpdateFromDto<TDto>(TEntity entity, TDto modificationDto);
        Task Delete(TEntity entity);

        //Func<IQueryable<TEntity>, IQueryable<TEntity>> ConstructInclude(IncludeType includeType = IncludeType.None);
    }
}
