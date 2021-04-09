using System;
using System.Collections.Generic;
using System.Text;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.BusinessLogic.Abstractions
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin GetAdminById(Guid adminId);
        Admin GetAdminByUserId(Guid userId);

    }

    
}
