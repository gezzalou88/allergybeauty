using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace AllergicBeauty.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public decimal RRP { get; set; }
        public bool Approved { get; set; }
        public string WebLink { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<File> Files { get; set; }

        
    }
}