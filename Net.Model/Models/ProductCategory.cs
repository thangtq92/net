using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Desctiption { get; set; }
        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}