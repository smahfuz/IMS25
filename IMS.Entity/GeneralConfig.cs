using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Entity.Core;

namespace IMS.Entity
{
    [Table("GeneralConfig")]
    public class GeneralConfig : AuditableEntity
    {

        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }


    }
}
