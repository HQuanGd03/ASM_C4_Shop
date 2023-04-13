using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.IServices
{
    public interface IBillDetailsServices
    {
        public bool CreateBillDetails(BillDetails p);
        public bool UpdateBillDetails(BillDetails p);
        public bool DeleteBillDetails(Guid id);
        public List<BillDetails> GetAllBillDetailss();
        public BillDetails GetBillDetailsById(Guid id);
        public List<BillDetails> GetBillDetailsByName(string name);
    }
}
