﻿using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels
{
    public class UserUpdateViewModel
    {
		[Required]
		[MaxLength(20)]
		[MinLength(4)]

		public string UserName { get; set; }
		[Required]
		[MaxLength(50)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		[MaxLength(35)]
		public string FullName { get; set; }

		[MaxLength(25)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[MaxLength(25)]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		public string ConfirmPassword { get; set; }
		[MaxLength(25)]
		[DataType(DataType.Password)]
		public string CurrentPassword { get; set; }

	}
}
