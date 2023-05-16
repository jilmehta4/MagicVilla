using MagicVilla_WebProject.Data;
using MagicVilla_WebProject.Models;
using MagicVilla_WebProject.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace MagicVilla_WebProject.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _context;
        public VillaRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.Villas.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}
