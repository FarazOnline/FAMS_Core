using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Sample
{
    [Table("Categories", Schema = "TestSchema")]
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public ICollection<Product> Products { get; set; }
    }
}