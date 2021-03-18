using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        
        private readonly ICarImageService _carImageService;

        public CarImagesController( ICarImageService carImageService)
        {
            
            _carImageService = carImageService;
        }


        [HttpPost("add")]
        public IActionResult Add([FromForm] CarImageDetailDto carImagesDto)
        {
            var result = _carImageService.Add(carImagesDto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] CarImageDetailDto carImagesDto)
        {
            var result = _carImageService.Update(carImagesDto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImageDetailDto carImagesDto)
        {
            var result = _carImageService.Delete(carImagesDto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getbycarimages")]
        public IActionResult GetById(int carId)
        {
            var result = _carImageService.GetByCarImages(carId);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _carImageService.GetAll();
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

    }
}
