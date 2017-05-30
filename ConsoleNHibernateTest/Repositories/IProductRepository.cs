using System;

namespace ConsoleNHibernateTest.Repositories
{
    interface IProductRepository
    {
        Product Get(Guid id);
        void Save(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
