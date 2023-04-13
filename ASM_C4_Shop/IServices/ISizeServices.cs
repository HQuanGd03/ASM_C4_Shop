using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.IServices
{
    public interface ISizeServices
    {
        public bool CreateSize(Size p);
        public bool UpdateSize(Size p);
        public bool DeleteSize(Guid id);
        public List<Size> GetAllSizes();
        public Size GetSizeById(Guid id);
        public List<Size> GetSizeByName(string name);
    }
}
