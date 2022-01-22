﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.DataAccess.Entities;

namespace WEBCarSell.BusinessLogic.DTO
{
    public class ModelDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public float Mileage { get; set; }

        public float Engine_Volume { get; set; }

        public string Color { get; set; }

        public string Transmission { get; set; }

        public string Drive { get; set; }

        public List<Brand> Brand { get; set; }

        public Price Price { get; set; }

        public Car_body Body { get; set; }

        public Region Region { get; set; }
    }
}
