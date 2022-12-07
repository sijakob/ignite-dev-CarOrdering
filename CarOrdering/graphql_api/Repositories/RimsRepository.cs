using graphql_api.Data;
using graphql_api.Interfaces;

namespace graphql_api.Repositories
{
    public class RimsRepository : IRimsRepository
    {
       private readonly ApplicationDbContext _appDbContext;
       public RimsRepository(ApplicationDbContext appDbContext) 
       {
            _appDbContext = appDbContext;
       }
        
    }
}