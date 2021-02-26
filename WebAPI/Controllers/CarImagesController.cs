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
        public static IWebHostEnvironment _environment;
        private readonly ICarImageService _carImageService;

        public CarImagesController(IWebHostEnvironment environment, ICarImageService carImageService)
        {
            _environment = environment;
            _carImageService = carImageService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getimages")]
        public IActionResult GetImages(int id)
        {
            var result = _carImageService.GetCarImages(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        


        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("file"))] IFormFile file, [FromForm] CarImage carImage)
        {
            string path = _environment.WebRootPath + "\\Images\\";
            var GuidPath = "Image"+"_"+
                DateTime.Now.ToString("yyyyMMddHHmmss")+"_"+
                Guid.NewGuid().ToString()+
                Path.GetExtension(file.FileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fileStream = System.IO.File.Create(path + GuidPath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            

            var result = _carImageService.Add(file,new CarImage
            {
                CarId = carImage.CarId,
                Date = DateTime.Now,
                ImagePath = GuidPath
            });

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(CarImage carImage)
        {

            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("file"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
