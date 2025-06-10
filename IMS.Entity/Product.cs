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
    [Table("Products")]
    public class Product : AuditableEntity
    {
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Old Name")]
        public string ProductOldName { get; set; }

        [Display(Name = "Product Unique Code")]
        public string ProductUniqueCode { get; set; }

        [Display(Name = "HS Code")]
        public string HsCode { get; set; }

        [Display(Name = "Description")]
        public string Details { get; set; }

        [Display(Name = "Category")]
        public Guid? CategoryId { get; set; }

        [Display(Name = "Price (BDT)")]
        public double? UnitPrice { get; set; }

        [Display(Name = "Price (USD)")]
        public double? UnitPriceUsd { get; set; }

        [Display(Name = "Unit")]
        public Guid? UnitId { get; set; }

        [ForeignKey("UnitId")]
        public virtual GeneralConfig Unit { get; set; }

        [Display(Name = "Packing Size")]
        public double? PackingSize { get; set; }

        [Display(Name = "Image")]
        public string ProductImage { get; set; }

        [Display(Name = "Manufacturer")]
        public Guid? ManufacturerId { get; set; }

        

        [Display(Name = "Country Of Origin")]
        public Guid? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual GeneralConfig Country { get; set; }

        [Display(Name = "Enable for PFI")]
        public bool? EnablePfi { get; set; }

        [Display(Name = "Enable for Material Transaction")]
        public bool? EnableMaterialTransaction { get; set; }

        [Display(Name = "Packing Details")]
        public string PackingDetails { get; set; }

        [Display(Name = "Ext")]
        public string Ext { get; set; }

    }
}
