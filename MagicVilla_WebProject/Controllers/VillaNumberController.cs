﻿using AutoMapper;
using MagicVilla_WebProject.Models.DTO;
using MagicVilla_WebProject.Models;
using MagicVilla_WebProject.Services;
using MagicVilla_WebProject.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MagicVilla_WebProject.Models.VM;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_WebProject.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper, IVillaService villaService)
        {
            _villaNumberService = villaNumberService;
            _mapper = mapper;
            _villaService = villaService;
        }

        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();

            var response = await _villaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        public async Task<IActionResult> CreateVillaNumber()
        {
            VillaNumberCreateVM villaNumberVM = new();

            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                villaNumberVM.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(i=>new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString() 
                });
            }
            return View(villaNumberVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVillaNumber(VillaNumberCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaNumberService.CreateAsync<APIResponse>(model.VillaNumber);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
            }
            return View(model);
        }

        //public async Task<IActionResult> UpdateVillaNumber(int villaNumberId)
        //{

        //    var response = await _villaNumberService.GetAsync<APIResponse>(villaNumberId);
        //    if (response != null && response.IsSuccess)
        //    {
        //        VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(response.Result));
        //        return View(_mapper.Map<VillaNumberUpdateDTO>(model));
        //    }

        //    return NotFound();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UpdateVillaNumber(VillaNumberUpdateDTO model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var response = await _villaNumberService.UpdateAsync<APIResponse>(model);
        //        if (response != null && response.IsSuccess)
        //        {
        //            return RedirectToAction(nameof(IndexVillaNumber));
        //        }
        //    }
        //    return View(model);
        //}

        //public async Task<IActionResult> DeleteVillaNumber(int VillaNumberId)
        //{

        //    var response = await _villaNumberService.GetAsync<APIResponse>(VillaNumberId);
        //    if (response != null && response.IsSuccess)
        //    {
        //        VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(response.Result));
        //        return View(model);
        //    }

        //    return NotFound();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteVillaNumber(VillaNumberDTO model)
        //{

        //    var response = await _villaNumberService.DeleteAsync<APIResponse>(model.VillaI);
        //    if (response != null && response.IsSuccess)
        //    {
        //        return RedirectToAction(nameof(IndexVillaNumber));
        //    }

        //    return View(model);
        //}
    }
}
