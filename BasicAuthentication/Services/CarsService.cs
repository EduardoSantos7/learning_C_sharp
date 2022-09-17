namespace BasicAuthentication.Services
{
    public class CarsService
    {
        string path = "";

        public async Task<List<Car>> Get() {
            string content = await File.ReadAllTextAsync(path);
        }
    }
}