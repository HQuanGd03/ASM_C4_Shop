﻿namespace ASM_C4_Shop.Models
{
    public class Role
    {
        public Guid Id { get; set; }    
        public string RoleName { get; set; }    
        public string Description { get; set; }
        public int Status { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
