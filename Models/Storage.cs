using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deritei_Norbert_Proiect.Models
{
    public class Storage
    {
        public int ID { get; set; }
        public string StorageName { get; set; }
        public ICollection<Product> Products { get; set; } //navigation property
    }
}
