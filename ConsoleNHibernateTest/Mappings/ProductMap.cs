using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ConsoleNHibernateTest.Mappings
{
    public class ProductMap: ClassMapping<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.GuidComb));
            Property(x => x.Name);
            Property(x => x.Category);
            Property(x => x.Price);
        }
    }
}
