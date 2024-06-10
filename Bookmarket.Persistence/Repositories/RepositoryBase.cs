using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookmarket.Persistence.Repositories;

public abstract class RepositoryBase<T>(BookmarketDbContext bookmarketDbContext) : IRepositoryBase<T> where T : class
{
	protected BookmarketDbContext BookmarketDbContext = bookmarketDbContext;

	public IQueryable<T> FindAll(bool trackChanges) => 
		!trackChanges ? BookmarketDbContext.Set<T>()
		.AsNoTracking() : BookmarketDbContext.Set<T>();

	public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, 
										bool trackChanges) => 
		!trackChanges ? BookmarketDbContext.Set<T>().Where(expression)
	.AsNoTracking() : BookmarketDbContext.Set<T>().Where(expression);

	public void Create(T entity) => BookmarketDbContext.Set<T>().Add(entity);
	public void Update(T entity) => BookmarketDbContext.Set<T>().Update(entity);
	public void Delete(T entity) => BookmarketDbContext.Set<T>().Remove(entity);
}