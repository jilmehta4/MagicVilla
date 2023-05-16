using MagicVilla_WebProject.Models.DTO;
using MagicVilla_WebProject.Services.IServices;

namespace MagicVilla_WebProject.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VillaService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI"); 
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
