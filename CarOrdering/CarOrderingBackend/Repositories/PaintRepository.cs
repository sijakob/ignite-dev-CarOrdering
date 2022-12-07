using CarOrderingBackend.Data;
using CarOrderingBackend.Interfaces;

namespace CarOrderingBackend.Repositories
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