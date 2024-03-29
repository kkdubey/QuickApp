﻿// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

using DAL.Repositories.Interfaces;

namespace DAL
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        IOrdersRepository Orders { get; }


        int SaveChanges();
    }
}
