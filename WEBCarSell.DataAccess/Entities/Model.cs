using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Interfaces;

namespace WEBCarSell.DataAccess.Entities
{
    public class Model : ISoftDeletable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public float Mileage { get; set; }

        public float Engine_Volume { get; set; }

        public string Color { get; set; }

        public string Transmission { get; set; }

        public string Drive { get; set; }

        public Brand Brand { get; set; }

        public bool IsDeleted { get; set; }

        public Price Price { get; set; }

        public Car_body Body { get; set; }

        public Region Region { get; set; }
    }
}
