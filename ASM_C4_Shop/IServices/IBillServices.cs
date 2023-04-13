﻿using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.IServices
{
    public interface IBillServices
    {
        public bool CreateBill(Bill p);
        public bool UpdateBill(Bill p);
        public bool DeleteBill(Guid id);
        public List<Bill> GetAllBills();
        public Bill GetBillById(Guid id);
        public List<Bill> GetBillByName(string name);
    }
}
