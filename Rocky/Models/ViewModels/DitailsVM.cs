namespace Rocky.Models.ViewModels
{
    public class DitailsVM
    {
        public DitailsVM()
        {
            Product = new Product();
        }
        public Product Product { get; set; }
        public bool ExistsInCart { get; set; }   
    }
}
