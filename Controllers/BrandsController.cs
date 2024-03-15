﻿using Business.Abstracts;
using Business.Concretes;
using Business.Dtos.Requests;
using Business.Dtos.Respones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);
            return Ok(createdBrandResponse);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_brandService.GetAll());
        }

    }
}
