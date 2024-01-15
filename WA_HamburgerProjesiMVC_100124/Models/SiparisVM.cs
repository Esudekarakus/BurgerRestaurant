using Domain.Entities;

namespace WA_HamburgerProjesiMVC_100124.Models
{
    public class SiparisVM
    {
        public SiparisVM()
        {
            menus=new List<Menu>();
            products=new List<Product>();
        }
        public List<Menu> menus {  get; set; }
        public List<Product> products { get; set; }
    }
}
