using graphql_api.Data;
using graphql_api.Interfaces;

namespace graphql_api.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
       private readonly ApplicationDbContext _appDbContext;
       public CarModelRepository(ApplicationDbContext appDbContext) 
       {
            _appDbContext = appDbContext;
       }
        
    }
}