using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;

namespace WEBCarSell.DataAccess.Entities
{
   public class Basket : ISoftDeletable
    {
        public Order Order { get; set; }

        public Model Model { get; set; }

        public bool IsDeleted { get; set; }
    }
}
