using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class BaseEntity
    {
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? MyProperty { get; set; }
        public bool IsActive{ get; set; }
    }
}
