using CarOrderingBackend.Data;
using CarOrderingBackend.Interfaces;

namespace CarOrderingBackend.Repositories
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