﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFetureID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public Feature FeatureID { get; set; }
        public bool Available { get; set; }


    }
}
