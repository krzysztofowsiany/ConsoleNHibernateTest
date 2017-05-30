using NHibernate.Mapping.ByCode;
using System;
using System.Xml.Serialization;

namespace ConsoleNHibernateTest.Mappings
{
    public class Mapper
    {
        public Mapper()
        {
            var mapper = new ModelMapper();
            mapper.AddMapping<ProductMap>();

            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            var xmlSerializer = new XmlSerializer(mapping.GetType());

            xmlSerializer.Serialize(Console.Out, mapping);
        }
    }
}
