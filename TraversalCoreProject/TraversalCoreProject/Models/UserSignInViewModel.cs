using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Pleas Enter Your Username")]
        public string Username { get; set; }=string.Empty;

        [Required(ErrorMessage = "Pleas Enter Your Password")]
        public string Password { get; set; }= string.Empty;
    }
}
