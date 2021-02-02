using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarDtoService
    {
        List<CarDto> GetAll(); 
    }
}
