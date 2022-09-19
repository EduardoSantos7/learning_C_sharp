using BasicAuthentication.Models;
using System.Text.Json;

namespace BasicAuthentication.Services
{
    public class CarService: ICarService
    {
        string path = "C:/Users/eduardosa/Documents/Repositories/EduardoSantos7/learning_C_sharp/BasicAuthentication/cars.json";

        public async Task<List<Car>> Get() {
            string content;
            try 
            {
                content = await File.ReadAllTextAsync(path);
            }
            catch (ArgumentException ex) {
                Console.WriteLine($"You forgot to add the path {ex}");
                return new List<Car>();
            }
            var cars = JsonSerializer.Deserialize<List<Car>>(content);
            return cars;
        }
    }
}