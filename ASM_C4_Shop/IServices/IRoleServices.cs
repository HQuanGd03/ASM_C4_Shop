using ASM_C4_Shop.Models;

namespace ASM_C4_Shop.IServices
{
    public interface IRoleServices
    {
        public bool CreateRole(Role p);
        public bool UpdateRole(Role p);
        public bool DeleteRole(Guid id);
        public List<Role> GetAllRoles();
        public Role GetRoleById(Guid id);
        public List<Role> GetRoleByName(string name);
    }
}
