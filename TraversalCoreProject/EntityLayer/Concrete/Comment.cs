using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public  string CommentUser { get; set; }= string.Empty;
        public DateTime CommentDate { get; set; }
        public string CommentContext { get; set; } = string.Empty;
        public bool CommentState { get; set; }
        public int DestinationID { get; set; }
        public Destination? Destination { get; set; }
    }
}