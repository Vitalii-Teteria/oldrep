using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WEBCarSell.DataAccess.Entities
{
    public class Order : ISoftDeletable
    {
        public Guid Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date), Required]
        public DateTime Date { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Count { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Employee Employee { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Client Client { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
