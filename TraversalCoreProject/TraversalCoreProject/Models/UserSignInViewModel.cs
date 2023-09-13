using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Pleas enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Pleas enter your Password")]
        public string Password { get; set; }
    }
}
