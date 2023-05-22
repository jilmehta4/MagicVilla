﻿using MagicVilla_WebProject.Models;
using MagicVilla_WebProject.Models.DTO;

namespace MagicVilla_WebProject.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);

        Task<T> CreateAsync<T>(VillaCreateDTO dto);

        Task<T> UpdateAsync<T>(VillaUpdateDTO dto);

        Task<T> DeleteAsync<T>(int id);
    }
}
