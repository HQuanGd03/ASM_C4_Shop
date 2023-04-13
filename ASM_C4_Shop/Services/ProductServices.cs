using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Services
{
    public class ProductServices : IProductServices
    {
        ShopDbContext Context;
        public ProductServices() {
             Context = new ShopDbContext();

        }
        public bool CreateProduct(Product p)
        {
            try {
                //THEEM 1 DOOI TUONG VAOF DB
                Context.Products.Add(p);
                Context.SaveChanges();
                return true;
            }
            catch (Exception){

                return false;

            }
        }

        public bool DeleteProduct(Guid id)
        {
            try
            {
                //Find(id) chi  dung duoc khi id laf khoa chinh
                dynamic Product = Context.Products.Find(id);//dynamic khiieu du lu naof cung nhan var thi k
                Context.Products.Remove(Product);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public List<Product> GetAllProducts()
        {
           return Context.Products.ToList();
            //laays data chi loi code hoac loi ket noi sql 
        }

        public Product GetProductById(Guid id)
        {
            return Context.Products.FirstOrDefault(p => p.Id == id);
             //return Context.Product.SingleOrDefault(p => p.Id == id);
             
        }

        public List<Product> GetProductByName(string name)
        {
           return Context.Products.Where(p=>p.Name.Contains(name)).ToList();

        }

        public bool UpdateProduct(Product p)
        {
            try
            {
    
                var Product = Context.Products.Find(p.Id);
                    Product.Name=p.Name;
                    Product.LinkAnh = p.LinkAnh;
                    Product.Price = p.Price;
                    Product.AvailableQuantity = p.AvailableQuantity;
                    Product.Supplier = p.Supplier;
                    Product.Description = p.Description;
                    Product.BrandId = p.BrandId;
                    Product.ColorId=p.ColorId;  
                    Product.SizeId = p.SizeId;                  
                    Product.Status = p.Status;
                //cos the them thuoc tinh
                Context.Products.Update(Product);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }




    }
}
