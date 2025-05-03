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
    [Table("ItemStock")]
    public class ItemStock : AuditableEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        public Guid? WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public string BatchNo { get; set; }
        public string Barcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Mfg { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Exp { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Warranty { get; set; }

        public double? PurchasePrice { get; set; }
        public double? SalePrice { get; set; }
        public double? QuantityStock { get; set; }
        public double? DamageStockQty { get; set; }

        public byte? Status { get; set; }
    }
}