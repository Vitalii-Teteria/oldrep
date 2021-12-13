using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WEBCarSell.DataAccess.Entities
{
   public class Price : ISoftDeletable
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Prices { get; set; }

        [Required(AllowEmptyStrings = false)]
        public bool IsDeleted { get; set; }
    }
}
