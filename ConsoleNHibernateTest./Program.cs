using ConsoleNHibernateTest.Repositories;
using NHibernate.Tool.hbm2ddl;
using System;

namespace ConsoleNHibernateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);

            var _productRepository = new NHibernateProductRepository();

            var product = new Product
            {
                Id= Guid.NewGuid(),
                Name = "Test",
                Category = "Cat",
                Price = new Random().Next(1,100)
            };

            _productRepository.Save(product);

            Console.ReadKey();
        }
    }
}
