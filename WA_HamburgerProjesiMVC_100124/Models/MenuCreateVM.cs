using Domain.Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel;

namespace WA_HamburgerProjesiMVC_100124.Models
{
	public class MenuCreateVM
	{
        public MenuCreateVM()
        {
            List<string> sizes = new List<string>() { "Small", "Medium", "Large" };
			Sizes = sizes;
        }
        public string Name { get; set; }
		public string Description { get; set; }

		[DisplayName("Image File")]
		public IFormFile ImageFile { get; set; }
		public IEnumerable<string> Sizes { get; set; }

		public string? ImagePath { get; set; }

		public string Size {  get; set; }
		
			
	}
}
