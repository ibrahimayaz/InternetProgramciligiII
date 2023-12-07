namespace ETicaret.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String? Name { get; set; } = String.Empty;
        public String? Description { get; set; } = String.Empty;
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

        public Product()
        {
            CreatedDate= DateTime.Now;  
        }
    }
}
