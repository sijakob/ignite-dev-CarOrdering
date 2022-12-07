using graphql_api.Data;
using graphql_api.Interfaces;

namespace graphql_api.Repositories
{
    public class PaintRepository : IPaintRepository
    {
       private readonly ApplicationDbContext _appDbContext;
       public PaintRepository(ApplicationDbContext appDbContext) 
       {
            _appDbContext = appDbContext;
       }
        
    }
}