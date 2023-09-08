﻿using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Password must be longer then {length - 1} characters"
			};
		}
	}
}
