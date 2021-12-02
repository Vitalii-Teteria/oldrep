using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;

namespace WEBCarSell.DataAccess.Entities
{
    public class Client: ISoftDeletable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public bool IsDeleted { get; set; }
    }
}
