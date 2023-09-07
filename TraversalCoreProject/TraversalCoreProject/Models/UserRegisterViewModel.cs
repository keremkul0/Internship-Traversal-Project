using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models 
{ 

	public class UserRegisterViewModel
	{
		[RequiredAttribute(ErrorMessage="Pleas enter your name")]
		public string Name { get; set; }

		public string Surname { get; set; }

		[Required(ErrorMessage = "Pleas Enter Your User Name")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Pleas Enter Your email adres")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Pleas Enter Your Password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Pleas Enter Your Password Again")]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }
	}
}
