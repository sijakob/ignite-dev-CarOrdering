using CarOrderingBackend.Data;
using CarOrderingBackend.Interfaces;

namespace CarOrderingBackend.Repositories
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