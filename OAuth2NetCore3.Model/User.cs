using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OAuth2NetCore3.model
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
        public bool Is_Activated { get; set; }
		public bool Is_Disabled { get; set; }
	}
}
