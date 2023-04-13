using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Services
{
    public class BrandServices : IBrandServices
    {
        ShopDbContext Context;

        public  BrandServices()
        {
            Context = new ShopDbContext();
        }

        public bool CreateBrand(Brand p)
        {
            try
            {
                Context.Brands.Add(p);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public bool DeleteBrand(Guid id)
        {
            try
            {
                dynamic Brand = Context.Brands.Find(id);
                Context.Brands.Remove(Brand);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public List<Brand> GetAllBrands()
        {
            return Context.Brands.ToList();
        }

        public Brand GetBrandById(Guid id)
        {
            return Context.Brands.FirstOrDefault(p => p.Id == id);
        }

        public List<Brand> GetBrandByName(string name)
        {
            return Context.Brands.Where(p => p.Name.Contains(name)).ToList();
        }

        public bool UpdateBrand(Brand p)
        {
            try
            {
                var Brand = Context.Brands.Find(p.Id);
                Brand.Name = p.Name;
                Brand.Status = p.Status;
                Context.Brands.Update(Brand);
                Context.SaveChanges();
                   return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool CreateCategory(Brand p)
        //{
        //    try
        //    {
        //        Context.Categorys.Add(p);
        //        Context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {

            //        return false;

            //    }
            //}

            //public bool DeleteCategory(Guid id)
            //{
            //    try
            //    {
            //        //Find(id) chi  dung duoc khi id laf khoa chinh
            //        dynamic Category = Context.Categorys.Find(id);//dynamic khiieu du lu naof cung nhan var thi k
            //        Context.Categorys.Remove(Category);
            //        Context.SaveChanges();
            //        return true;
            //    }
            //    catch (Exception)
            //    {

            //        return false;

            //    }
            //}

            //public List<Brand> GetAllCategorys()
            //{
            //    return Context.Categorys.ToList();
            //    //laays data chi loi code hoac loi ket noi sql 
            //}

            //public Brand GetCategoryById(Guid id)
            //{
            //    return Context.Categorys.FirstOrDefault(p => p.Id == id);
            //}

            //public List<Brand> GetCategoryByName(string name)
            //{
            //    return Context.Categorys.Where(p => p.Name.Contains(name)).ToList();
            //}

            //public bool UpdateCategory(Brand p)
            //{
            //    try
            //    {

            //        var Category = Context.Categorys.Find(p.Id);
            //        Category.Name = p.Name;
            //        Category.Status = p.Status;

            //        //cos the them thuoc tinh
            //        Context.Categorys.Update(Category);
            //        Context.SaveChanges();
            //        return true;
            //    }
            //    catch (Exception)
            //    {

            //        return false;

            //    }
            //}
    }
}
