// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OrdersRepository : Repository<Order>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        { }




        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
