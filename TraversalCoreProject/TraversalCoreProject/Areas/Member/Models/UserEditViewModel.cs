namespace TraversalCoreProject.Areas.Member.Models
{
	public class UserEditViewModel
	{
		public string Name { get; set; } = string.Empty;
		public string Surname { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string ConfirmPassword {  get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string Email { get; set; }=string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public IFormFile Image { get; set; }

	}
}
