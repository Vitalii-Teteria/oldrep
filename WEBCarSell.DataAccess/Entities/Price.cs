using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;

namespace WEBCarSell.DataAccess.Entities
{
   public class Price : ISoftDeletable
    {
        public Guid Id { get; set; }

        public int Prices { get; set; }

        public bool IsDeleted { get; set; }
    }
}
