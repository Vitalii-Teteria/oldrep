using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;

namespace WEBCarSell.DataAccess.Entities
{
    public class Order : ISoftDeletable
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }

        public Employee Employee { get; set; }

        public Client Client { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
