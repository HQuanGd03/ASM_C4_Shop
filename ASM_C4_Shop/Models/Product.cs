namespace ASM_C4_Shop.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LinkAnh { get; set; }
        public int Price { get; set; }
        public int AvailableQuantity { get; set; }
        public int Status { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }

        public Guid BrandId { get; set; }
        public Guid ColorId { get; set; }
        public Guid SizeId { get; set; }

        public virtual ICollection<BillDetails> BillDetails { get; set; }
        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
      

    }
}
