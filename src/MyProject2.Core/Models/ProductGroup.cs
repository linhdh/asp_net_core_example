using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject2.Models
{
    [Table("ProductGroups")]
    public class ProductGroup : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
