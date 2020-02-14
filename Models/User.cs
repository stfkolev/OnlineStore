using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }

        public ICollection<Item> items { get; set; }

    }
}
