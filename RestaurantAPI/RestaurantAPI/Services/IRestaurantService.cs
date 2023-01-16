using RestaurantAPI.Models;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        List<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        bool Delete(int id);
    }
}