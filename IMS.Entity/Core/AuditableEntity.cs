using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Entity.Core
{
    public class AuditableEntity : Entity
    {
        public Guid? CreatedBy { get; set; }
        public DateTime Created {  get; set; }
        public Guid? LastUpdatedBy { get; set; }
        public DateTime LastUpdated { get; set; }

        public AuditableEntity()
        {
            Created = DateTime.Now;
        }

    }
}
