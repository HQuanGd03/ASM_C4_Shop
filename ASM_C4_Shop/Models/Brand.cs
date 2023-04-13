namespace ASM_C4_Shop.Models
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
