using CarOrderingBackend.Data;
using CarOrderingBackend.Interfaces;

namespace CarOrderingBackend.Repositories
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