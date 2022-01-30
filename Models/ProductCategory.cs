﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deritei_Norbert_Proiect.Models
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
