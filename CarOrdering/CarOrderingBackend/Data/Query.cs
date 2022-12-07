using CarOrderingBackend.Models;
namespace CarOrderingBackend
{
    public class Query
    {
        public IQueryable<Car> GetCars =>
            new List<Car>().AsQueryable();
    }
}