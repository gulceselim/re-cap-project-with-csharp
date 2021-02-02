using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CarDto : IEntity
    {
        public int Id { get; set; }
        public string BrandName{ get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Decription { get; set; }
    }
}
