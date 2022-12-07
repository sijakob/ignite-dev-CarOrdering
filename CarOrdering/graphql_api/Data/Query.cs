using graphql_api.Models;
namespace graphql_api
{
    public class Query
    {
        public IQueryable<Car> GetCars =>
            new List<Car>().AsQueryable();
    }
}