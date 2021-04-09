using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookWorms.BusinessLogic.Abstractions;
using BookWorms.BusinessLogic.DataModel;

namespace BookWorms.DataAccess
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(BookWormsDbContext dbContext) : base(dbContext)
        {

        }
        public Admin GetAdminByUserId(Guid userId)
        {
            return dbContext.Admins
                            .Where(admin => admin.UserId == userId)
                            .SingleOrDefault();
        }
        public Admin GetAdminById(Guid userId)
        {
            return dbContext.Admins
                            .Where(admin => admin.UserId == userId)
                            .SingleOrDefault();
        }
    }
}
