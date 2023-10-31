using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.Services.CarServices
{
    public interface ICarService
    {
        Task<List<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(Guid id);
        Task<List<Car>> GetCarsByBrandNameAsync(string brandName);
        Task<List<Car>> GetCarsByModelNameAsync(string modelName);
        Task<List<Car>> GetCarsByGenerationNameAsync(string generationName);
        Task AddCarAsync(Car car);
        Task AddCarsAsync();
        Task UpdateCarAsync(Car car);
        Task DeleteCarByIdAsync(Guid id);
    }
}
