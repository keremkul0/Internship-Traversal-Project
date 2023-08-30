using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Title2 { get; set; } = string.Empty;
        public string Description2 { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;   

        public bool IsActive { get; set; }
    }
}
