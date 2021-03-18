using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDetailDto:IDto
    {
        public int Id { get; set; } = 0;
        public int CarId { get; set; }
        //public string CarName { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; }
    }
}
