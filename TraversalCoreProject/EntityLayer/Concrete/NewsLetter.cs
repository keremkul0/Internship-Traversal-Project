using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewsLetter
    {
        [Key]
        public string NewLetterID { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
    }
}
