using MagicVilla_WebProject.Models;
using MagicVilla_WebProject.Models.DTO;

namespace MagicVilla_WebProject.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);

        Task<T> CreateAsync<T>(VillaNumberCreateDTO dto);

        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto);

        Task<T> DeleteAsync<T>(int id);
    }
}
