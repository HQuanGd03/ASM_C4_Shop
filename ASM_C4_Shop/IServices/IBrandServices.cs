using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.IServices
{
    public interface IBrandServices
    {
        public bool CreateBrand(Brand p);
        public bool UpdateBrand(Brand p);
        public bool DeleteBrand(Guid id);
        public List<Brand> GetAllBrands();
        public Brand GetBrandById(Guid id);
        public List<Brand> GetBrandByName(string name);
    }
}
