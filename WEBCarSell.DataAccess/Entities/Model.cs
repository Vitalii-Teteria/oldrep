using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WEBCarSell.DataAccess.Entities
{
    public class Model : ISoftDeletable
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date), Required]
        public DateTime Year { get; set; }

        [Required(AllowEmptyStrings =false)]
        public float Mileage { get; set; }

        [Required(AllowEmptyStrings = false)]
        public float Engine_Volume { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Color { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Transmission { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Drive { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Brand Brand { get; set; }

        public bool IsDeleted { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Price Price { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Car_body Body { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Region Region { get; set; }
    }
}
