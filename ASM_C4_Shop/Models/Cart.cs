namespace ASM_C4_Shop.Models
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }

        public ICollection<CartDetails> CartDetails { get; set; }
        public User User { get; set; }
    }
}
