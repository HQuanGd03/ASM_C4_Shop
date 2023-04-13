namespace ASM_C4_Shop.Models
{
    public class Size
    {
        public Guid Id { get; set; }
        public string Kichthuoc { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
