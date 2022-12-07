using CarOrderingBackend.Data;
using CarOrderingBackend.Interfaces;

namespace CarOrderingBackend.Repositories
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