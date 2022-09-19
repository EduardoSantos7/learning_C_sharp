using BasicAuthentication.Models;

namespace BasicAuthentication.Services
{
    public interface ICarService
    {
        public Task<List<Car>> Get();
    }
}