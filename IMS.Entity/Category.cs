using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Entity.Core;

namespace IMS.Entity
{
    [Table("Categories")]
    public class Category : AuditableEntity
    {
        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        [Display(Name = "Category Parent")]
        public Guid? CategoryParentId { get; set; }

        [ForeignKey("CategoryParentId")]
        public virtual Category CategoryParent { get; set; }

        public virtual ICollection<Category> ChildCategoryCollection { get; set; }
    }
}
