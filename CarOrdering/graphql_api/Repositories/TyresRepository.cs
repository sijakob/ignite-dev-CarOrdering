using graphql_api.Data;
using graphql_api.Interfaces;

namespace graphql_api.Repositories
{
    public class TyresRepository : ITyresRepository
    {
       private readonly ApplicationDbContext _appDbContext;
       public TyresRepository(ApplicationDbContext appDbContext) 
       {
            _appDbContext = appDbContext;
       }
        
    }
}