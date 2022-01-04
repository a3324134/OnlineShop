using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int Stock { get; set; }
        public virtual Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
