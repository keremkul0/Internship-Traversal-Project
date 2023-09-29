using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models 
{ 
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage="Please enter your name")]
		public string Name { get; set; } = string.Empty;
		[Required(ErrorMessage = "Please enter your surname")]
		public string Surname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your User Name")]
		public string UserName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your email adres")]
		public string Mail { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your Password")]
		public string Password { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please Enter Your Password Again")]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }=string.Empty;
	}
}
