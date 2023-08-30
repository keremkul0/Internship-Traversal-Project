using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2Id { get; set; }
        public string Title1 { get; set; } =string.Empty;
        public string Description { get; set; } = string.Empty;     
        public string Title2 { get; set; } = string.Empty;  
        public string Description2 { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
