using MagicVilla_WebProject.Models;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace MagicVilla_WebProject.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
