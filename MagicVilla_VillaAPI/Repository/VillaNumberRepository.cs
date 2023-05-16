using MagicVilla_WebProject.Data;
using MagicVilla_WebProject.Models;
using MagicVilla_WebProject.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace MagicVilla_WebProject.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _context;
        public VillaNumberRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.VillaNumbers.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}
