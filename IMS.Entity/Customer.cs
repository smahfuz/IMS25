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
    [Table("Customers")]
    public class Customer : AuditableEntity
    {
        [Display(Name = "Customer Code")]
        public string CustomerCode { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string HOAddress { get; set; }

        [Display(Name = "Factory Address")]
        public string FactoryAddress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        public Guid? CountryId { get; set; }

        [Display(Name = "Irc No")]
        public string IrcNo { get; set; }

        [Display(Name = "Tin No")]
        public string TinNo { get; set; }

        [Display(Name = "Bin No")]
        public string BinNo { get; set; }

        [Display(Name = "Bond License No")]
        public string ImportLicenseNo { get; set; }

        [Display(Name = "Bond License Date Of Issue")]
        [DataType(DataType.Date)]
        public DateTime? ImportLicenseDateOfIssue { get; set; }

        [Display(Name = "Bond License Date Of Expiry")]
        [DataType(DataType.Date)]
        public DateTime? ImportLicenseDateOfExpiry { get; set; }

        [Display(Name = "Import Reg. No")]
        public string ImportRegistrationNo { get; set; }

        [Display(Name = "Bangladesh Bank Reg. No")]
        public string BangladeshBankRegistrationNo { get; set; }

        [Display(Name = "AcM")]
        public Guid? AcmId { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Bank AC Number")]
        public string BankAcNumber { get; set; }

        [Display(Name = "Branch")]
        public string Branch { get; set; }

        [Display(Name = "Swift Code")]
        public string SwiftCode { get; set; }

        [Display(Name = "Is Seller")]
        public bool IsSeller { get; set; }

        [Display(Name = "Is Customer")]
        public bool IsBuyer { get; set; }

        [Display(Name = "Fax")]
        public string FaxNo { get; set; }

        [Display(Name = "Ext")]
        public string Ext1 { get; set; }

        [Display(Name = "Vat Code")]
        public string VatCode { get; set; }


        [Display(Name = "Parent Group")]
        public Guid? ParentGroupId { get; set; }

        [ForeignKey("ParentGroupId")]
        public virtual Customer ParentGroup { get; set; }
    }
}
