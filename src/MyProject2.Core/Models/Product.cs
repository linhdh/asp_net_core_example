using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject2.Models
{
    [Table("Products")]
    public class Product : Entity
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; }
        public uint Quantity { get; set; }

        public Product(int groupId, string name, string description, float price, string picture, uint quantity)
        {
            GroupId = groupId;
            Name = name;
            Description = description;
            Price = price;
            Picture = picture;
            Quantity = quantity;
        }
    }
}
