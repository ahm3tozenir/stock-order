using ExampleAPI.Contexts;
using ExampleAPI.Core;
using ExampleAPI.Entities;
using ExampleAPI.Repositories.Abstracts;

namespace ExampleAPI.Repositories.Concretes;

public class StockRepository : BaseRepository<Stock>, IStockRepository
{
    public StockRepository(ExampleDbContext context) : base(context)
    {
    }
}

