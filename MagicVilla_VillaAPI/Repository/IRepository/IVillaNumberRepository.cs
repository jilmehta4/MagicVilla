using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
