using CarOrderingBackend.Data;
using CarOrderingBackend.Models;
namespace CarOrderingBackend
{
    public class Query
    {
        public IQueryable<Car> getCars([Service] ApplicationDbContext context) =>
            context.Cars;
    }
}