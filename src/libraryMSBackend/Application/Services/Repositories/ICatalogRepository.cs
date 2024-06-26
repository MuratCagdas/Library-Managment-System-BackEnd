using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICatalogRepository : IAsyncRepository<Catalog, Guid>, IRepository<Catalog, Guid>
{
    IQueryable<Catalog> Table { get; }
    Task<int> CountAsync();
}