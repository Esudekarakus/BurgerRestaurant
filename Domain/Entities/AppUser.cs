using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class AppUser : IdentityUser
	{
		//public string UserName {  get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		//public string Email {  get; set; }
		public IEnumerable<Order> Orders { get; set; }

	}
}
