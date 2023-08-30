using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public string ContactID { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public string ContactTitle { get; set; }= string.Empty;
        public string ContactDescription { get; set; }=string.Empty;
        public string MapLocation { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
