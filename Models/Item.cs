using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double price { get; set; }

    }
}
