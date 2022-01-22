using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.BusinessLogic.DTO;
using WEBCarSell.DataAccess.Entities;

namespace WEBCarSell.BusinessLogic.Extensions
{
    public static class MapperToDto
    {
        public static ModelDto ToDto(this Model model) 
        {
            return model == null ? null :
                new ModelDto
                {
                    Id = model.Id,
                    Name = model.Name,
                    Year= model.Year,
                    Mileage = model.Mileage,
                    Engine_Volume = model.Engine_Volume,
                    Color = model.Color,
                    Transmission = model.Transmission,
                    Drive = model.Drive,
                    Price = model.Price
                };
        }
    }
}
