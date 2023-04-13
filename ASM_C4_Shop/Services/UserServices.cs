﻿using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.Services
{
    public class UserServices : IUserServices
    {
        ShopDbContext Context;
        public UserServices()
        {
            Context = new ShopDbContext();

        }
        public bool CreateUser(User p)
        {
            try
            {
                //THEEM 1 DOOI TUONG VAOF DB
                Context.Users.Add(p);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public bool DeleteUser(Guid id)
        {
            try
            {
                //Find(id) chi  dung duoc khi id laf khoa chinh
                dynamic User = Context.Users.Find(id);//dynamic khiieu du lu naof cung nhan var thi k
                Context.Users.Remove(User);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public List<User> GetAllUsers()
        {
            return Context.Users.ToList();
            //laays data chi loi code hoac loi ket noi sql 
        }

        public User GetUserById(Guid id)
        {
            return Context.Users.FirstOrDefault(p => p.Id == id);
            //return Context.Product.SingleOrDefault(p => p.Id == id);
        }

        public List<User> GetUserByName(string name)
        {
            return Context.Users.Where(p => p.Username.Contains(name)).ToList();
        }

        public bool UpdateUser(User p)
        {
            try
            {
       
                var User = Context.Users.Find(p.Id);
             
                User.Email = p.Email;
                User.Username = p.Username;
                User.Password = p.Password;
                User.RoleId = p.RoleId;
                User.Status = p.Status;
                //cos the them thuoc tinh
                Context.Users.Update(User);
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

