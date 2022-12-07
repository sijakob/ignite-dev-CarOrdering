using graphql_api.Data;
using graphql_api.Interfaces;

namespace graphql_api.Repositories
{
    public class CarRepository : ICarRepository
    {
       private readonly ApplicationDbContext _appDbContext;
       public CarRepository(ApplicationDbContext appDbContext) 
       {
            _appDbContext = appDbContext;
       }
    }
}