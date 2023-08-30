using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string Client { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string ClientImage { get; set; } = string.Empty; 
        public bool IsActive { get; set; }
    }
}
