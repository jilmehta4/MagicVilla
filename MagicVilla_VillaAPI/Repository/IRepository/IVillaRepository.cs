using MagicVilla_WebProject.Models;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace MagicVilla_WebProject.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);

    }
}
